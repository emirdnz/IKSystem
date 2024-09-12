using Microsoft.AspNetCore.Mvc;

namespace IKAPI.Areas.Hr.Controllers
{
    [Area("Hr")]
    public class HrController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeManagement() { return View(); }    
        public IActionResult TaskManagement() { return View(); }    
        public IActionResult LeaveRequests() { return View(); }    
        public IActionResult Reports() { return View(); }    

    }
}
