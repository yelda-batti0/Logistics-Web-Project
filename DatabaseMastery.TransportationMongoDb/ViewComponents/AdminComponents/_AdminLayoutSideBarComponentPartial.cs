using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportationMongoDb.ViewComponents.AdminComponents
{
    public class _AdminLayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
