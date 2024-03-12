using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManager.GetList();
            return View(values);
        }

        public IActionResult DestinationDetails()
        {
            return View();
        }
    }
}
