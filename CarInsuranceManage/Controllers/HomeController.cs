using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult IndexUser()
        {
            return View("Views/User/HomeUser/IndexUser.cshtml");
        }
       
       

         public IActionResult Index()
        {
            return View("~/Views/Admin/Home/Index.cshtml"); 
        }

        public IActionResult Dashboard()
        {
            return View("~/Views/Admin/Home/Dashboard.cshtml");
        }

    }
}
