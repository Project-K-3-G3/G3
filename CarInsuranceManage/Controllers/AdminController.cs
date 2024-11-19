using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {
            ViewData["Layout"] = "_LayoutAdmin.cshtml"; // Chỉ định layout cho tất cả các action trong controller này
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminDashboard()
        {
            return View();
        }
    }
}
