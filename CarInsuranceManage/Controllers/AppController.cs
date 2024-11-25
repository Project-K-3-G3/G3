using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Calender()
        {
            return View();
        }
    }
}
