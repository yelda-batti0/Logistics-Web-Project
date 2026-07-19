using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportationMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
