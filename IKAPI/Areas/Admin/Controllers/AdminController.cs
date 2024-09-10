using Microsoft.AspNetCore.Mvc;

namespace IKAPI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserManagement() { return View(); }

        public IActionResult Reporting() { return View(); }

        public IActionResult Log() { return View(); }   
       
        public IActionResult CompanyApproval() { return View(); }   

    }
}
