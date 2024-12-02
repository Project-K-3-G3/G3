using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers.Customer
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View("~/Views/Customer/Account/Login.cshtml");
        }
        public IActionResult Register()
        {
            return View("~/Views/Customer/Account/Register.cshtml");
        }
        public IActionResult Blog()
        {
            return View("~/Views/Customer/Account/Blog.cshtml");
        }
          public IActionResult Profile()
        {
            return View("~/Views/Customer/Account/Profile.cshtml");
        }
          public IActionResult Info_Insurance()
        {
            return View("~/Views/Customer/Account/Info_Insurance.cshtml");
        }
    }
}
