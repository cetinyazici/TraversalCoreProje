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

        public IActionResult DestinationDetails(int id)
        {
            var values = destinationManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }


    }
}
