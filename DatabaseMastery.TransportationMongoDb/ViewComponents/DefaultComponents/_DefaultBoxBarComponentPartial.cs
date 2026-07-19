using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportationMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultBoxBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
