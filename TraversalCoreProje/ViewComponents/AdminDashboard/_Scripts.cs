using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AdminDashboard
{
    public class _Scripts : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
