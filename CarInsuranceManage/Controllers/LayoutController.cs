using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
