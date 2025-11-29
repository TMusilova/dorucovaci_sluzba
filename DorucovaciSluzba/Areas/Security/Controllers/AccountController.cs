using Microsoft.AspNetCore.Mvc;

namespace DorucovaciSluzba.Areas.Security.Controllers
{
    public class AccountController : Controller
    {
        [Area("Security")]
        public class AccountsController : Controller 
        {
            public IActionResult Register()
            {
                return View();
            }

            public IActionResult Login()
            {
                return View();
            }
        }
    }
}
