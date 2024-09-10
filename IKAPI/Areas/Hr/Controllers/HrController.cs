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

    }
}
