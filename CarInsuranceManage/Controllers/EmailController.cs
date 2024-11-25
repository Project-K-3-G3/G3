using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }
        public IActionResult Read()
        {
            return View();
        }
        public IActionResult Compose()
        {
            return View();
        }
    }
}
