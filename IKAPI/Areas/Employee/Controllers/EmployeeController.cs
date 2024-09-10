using Microsoft.AspNetCore.Mvc;

namespace IKAPI.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            return View();
        }

        public IActionResult LeaveRequest() { return View(); }

        public IActionResult Profile() { return View(); }

        public IActionResult Taskmanagement() { return View(); }
    }
}
