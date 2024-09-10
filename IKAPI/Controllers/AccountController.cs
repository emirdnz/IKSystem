using Microsoft.AspNetCore.Mvc;

namespace IKAPI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
