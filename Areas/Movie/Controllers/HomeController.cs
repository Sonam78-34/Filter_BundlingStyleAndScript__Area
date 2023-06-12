using Microsoft.AspNetCore.Mvc;

namespace BundlingStyleAndScriptMVCASp.Areas.Movie.Controllers
{
    [Area("Movie")]
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
