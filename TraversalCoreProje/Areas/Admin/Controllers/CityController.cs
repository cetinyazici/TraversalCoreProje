using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(cityModels);
            return Json(jsonCity);
        }

        public static List<CityModel> cityModels = new List<CityModel>
        {
            new CityModel()
            {
                CityId = 1,
                CityName = "Test",
                CityCountry="Test",
            },
            new CityModel()
            {
                CityId= 2,
                CityName= "Test",
                CityCountry="Test",
            },
            new CityModel()
            {
                CityId =3,
                CityName= "Test",
                CityCountry="Test",
            }
        };

    }
}
