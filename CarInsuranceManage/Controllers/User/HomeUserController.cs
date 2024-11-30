using System.Diagnostics;
using CarInsuranceManage.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class HomeUserController : Controller
    {
        private readonly ILogger<HomeUserController> _logger;

        public HomeUserController(ILogger<HomeUserController> logger)
        {
            _logger = logger;
        }

        public IActionResult about()
        {
            return View("~/Views/User/HomeUser/about.cshtml");
        }

        public IActionResult blog()
        {
            return View("~/Views/User/HomeUser/blog.cshtml");
        }

        public IActionResult privacy()
        {
            return View("~/Views/User/HomeUser/privacy.cshtml");
        }

        public IActionResult insurance_form()
        {
            return View("~/Views/User/HomeUser/insurance_form.cshtml");
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
