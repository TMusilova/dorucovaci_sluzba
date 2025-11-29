using Microsoft.AspNetCore.Identity;
using DorucovaciSluzba.Application.Abstraction;
using DorucovaciSluzba.Application.ViewModels;
using DorucovaciSluzba.Domain.Enums;

namespace DorucovaciSluzba.Infrastructure.Identity
{
    public class AccountIdentityService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountIdentityService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> Login(LoginViewModel vm)
        {
            var result = await _signInManager.PasswordSignInAsync(vm.Username, vm.Password, true, true);
            return result.Succeeded;
        }

        public Task Logout()
        {
            return _signInManager.SignOutAsync();
        }

        public async Task<string[]> Register(RegisterViewModel vm, params Roles[] roles)
        {
            User user = new User()
            {
                UserName = vm.Username,
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                Email = vm.Email,
                PhoneNumber = vm.Phone
            };

            string[] errors = null;
            var result = await _userManager.CreateAsync(user, vm.Password);

            if (result.Succeeded)
            {
                foreach (var role in roles)
                {
                    var resultRole = await _userManager.AddToRoleAsync(user, role.ToString());
                    if (!resultRole.Succeeded)
                    {
                        foreach (var error in resultRole.Errors)
                        {
                            // Přidáme chyby z role assignmentu
                        }
                    }
                }
            }

            if (result.Errors != null && result.Errors.Any())
            {
                errors = result.Errors.Select(e => e.Description).ToArray();
            }

            return errors;
        }
    }
}