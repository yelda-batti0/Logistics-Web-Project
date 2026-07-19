using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportationMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
