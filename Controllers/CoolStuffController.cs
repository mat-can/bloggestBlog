using Microsoft.AspNetCore.Mvc;

namespace CoolestMVCProjectEver.Controllers
{
    public class CoolStuffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
