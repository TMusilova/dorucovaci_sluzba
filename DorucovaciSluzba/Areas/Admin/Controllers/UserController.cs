using DorucovaciSluzba.Domain.Enums;
using DorucovaciSluzba.Infrastructure.Identity;
using DorucovaciSluzba.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DorucovaciSluzba.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin))]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UserController(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // Výpis všech uživatelů
        public async Task<IActionResult> Select()
        {
            var users = _userManager.Users.ToList();

            // Pro každého uživatele načti jeho role
            var userRoles = new Dictionary<int, IList<string>>();
            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                userRoles[user.Id] = roles;
            }

            ViewBag.UserRoles = userRoles;
            return View(users);
        }

        // EDIT - GET
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            // Zjisti aktuální roli uživatele
            var userRoles = await _userManager.GetRolesAsync(user);
            var currentRole = userRoles.FirstOrDefault();
            var roleId = 0;

            if (!string.IsNullOrEmpty(currentRole))
            {
                var role = await _roleManager.FindByNameAsync(currentRole);
                roleId = role?.Id ?? 0;
            }

            var viewModel = new EditUserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName ?? string.Empty,
                LastName = user.LastName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                Telefon = user.Telefon,
                DatumNarozeni = user.DatumNarozeni,
                Ulice = user.Ulice,
                CP = user.CP,
                Mesto = user.Mesto,
                Psc = user.Psc,
                RoleId = roleId,
                DostupneRole = _roleManager.Roles.ToList()
            };

            return View(viewModel);
        }

        // EDIT - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.DostupneRole = _roleManager.Roles.ToList();
                return View(model);
            }

            var user = await _userManager.FindByIdAsync(model.Id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            // Automaticky generuje UserName z emailu
            var userName = model.Email.Split('@')[0];

            // Aktualizuj data uživatele
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.NormalizedEmail = model.Email.ToUpper();
            user.UserName = userName;
            user.NormalizedUserName = userName.ToUpper();
            user.Telefon = model.Telefon;
            user.DatumNarozeni = model.DatumNarozeni;
            user.Ulice = model.Ulice;
            user.CP = model.CP;
            user.Mesto = model.Mesto;
            user.Psc = model.Psc;

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                model.DostupneRole = _roleManager.Roles.ToList();
                return View(model);
            }

            // Aktualizuj roli
            var currentRoles = await _userManager.GetRolesAsync(user);
            var selectedRole = await _roleManager.FindByIdAsync(model.RoleId.ToString());

            if (selectedRole != null)
            {
                // Odeber všechny staré role
                if (currentRoles.Any())
                {
                    await _userManager.RemoveFromRolesAsync(user, currentRoles);
                }

                // Přidej novou roli
                await _userManager.AddToRoleAsync(user, selectedRole.Name!);
            }

            TempData["SuccessMessage"] = $"Uživatel {user.FirstName} {user.LastName} byl úspěšně aktualizován!";
            return RedirectToAction(nameof(Select));
        }

        // Smazání uživatele
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Select));
            }

            return BadRequest("Nepodařilo se smazat uživatele.");
        }
    }
}