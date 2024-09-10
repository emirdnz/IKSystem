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
    }
}
