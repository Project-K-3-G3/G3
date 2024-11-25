using Microsoft.AspNetCore.Mvc;

namespace CarInsuranceManage.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Basic_Table()
        {
            return View();
        }
        public IActionResult Data_Table()
        {
            return View();
        }
    }
}
