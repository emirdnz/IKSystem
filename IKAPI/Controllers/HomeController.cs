using Ik.Dal.Context;
using Ik.entities.Concrete;
using IKAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace IKAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IKDB _context;

        public HomeController(ILogger<HomeController> logger, IKDB context)
        {
            _logger = logger;
            _context = context;
        }


       public IActionResult Index() { return View(); }  



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
