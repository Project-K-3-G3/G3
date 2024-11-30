using System.Diagnostics;
using CarInsuranceManage.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class InsuranceController : Controller
    {
        private readonly ILogger<InsuranceController> _logger;

        public InsuranceController(ILogger<InsuranceController> logger)
        {
            _logger = logger;
        }

        public IActionResult services()
        {
            return View("~/Views/User/Insurance/services.cshtml");
        }

       


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
