using System.Diagnostics;
using CarInsuranceManage.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        public IActionResult sign_in()
        {
            return View("~/Views/User/Account/sign_in.cshtml");
        }

        public IActionResult sign_up()
        {
            return View("~/Views/User/Account/sign_up.cshtml");
        }

       


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
