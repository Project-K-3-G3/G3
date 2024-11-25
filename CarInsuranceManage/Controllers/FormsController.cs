using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Basic_Form()
        {
            return View();
        }
        public IActionResult Form_Validation()
        {
            return View();
        }
        public IActionResult Step_Form()
        {
            return View();
        }
        public IActionResult Editor()
        {
            return View();
        }
        public IActionResult Picker()
        {
            return View();
        }
    }
}
