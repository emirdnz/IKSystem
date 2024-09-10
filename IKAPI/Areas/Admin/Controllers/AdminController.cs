using Ik.Dal.Context;
using Ik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IKAPI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly IKDB _context; 

       
        public AdminController(IKDB context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserManagement()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public IActionResult Create() { return View(); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
               
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

              
                return RedirectToAction(nameof(UserManagement));
            }

           
            return View(user);
        }

        public IActionResult Reporting() { return View(); }

        public IActionResult Log() { return View(); }

        public IActionResult CompanyApproval() { return View(); }

        public IActionResult Login() { return View(); }

        public IActionResult AccountLog() { return View(); }
    }
}
