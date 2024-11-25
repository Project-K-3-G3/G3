using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult Nestedable()
        {
            return View();
        }
        public IActionResult Noui_Slider()
        {
            return View();
        }
        public IActionResult Sweet_Alert()
        {
            return View();
        }
        public IActionResult Toastr()
        {
            return View();
        }
    }
}
