using DorucovaciSluzba.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DorucovaciSluzba.Areas.Security.Controllers
{
    [Area("Security")]
    public class AccountController : Controller 
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
