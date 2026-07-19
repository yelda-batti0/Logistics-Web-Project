using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportationMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultMobileMenuComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
