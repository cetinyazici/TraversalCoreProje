using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager subAboutManager = new(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = subAboutManager.GetList();
            return View(values);  
        }
    }
}
