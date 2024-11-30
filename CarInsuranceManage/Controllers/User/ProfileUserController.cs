using System.Diagnostics;
using CarInsuranceManage.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class ProfileUserController : Controller
    {
        private readonly ILogger<ProfileUserController> _logger;

        public ProfileUserController(ILogger<ProfileUserController> logger)
        {
            _logger = logger;
        }

        public IActionResult profile()
        {
            return View("~/Views/User/ProfileUser/profile.cshtml");
        }

        public IActionResult profile_booking()
        {
            return View("~/Views/User/ProfileUser/profile_booking.cshtml");
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
