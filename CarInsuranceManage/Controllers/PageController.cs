using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Lock_Screen()
        {
            return View();


        }
        public IActionResult Not_Found()
        {
            return View();
        }
    }
}
