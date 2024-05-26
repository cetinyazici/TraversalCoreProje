using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemeberDashboard
{
    public class _MemberStatistic : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
