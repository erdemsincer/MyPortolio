using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _NavBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
