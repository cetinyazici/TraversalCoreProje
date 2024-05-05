using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Member/[controller]/[action]")]
    public class DestinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
