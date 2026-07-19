using DatabaseMastery.TransportationMongoDb.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportationMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultAboutComponentpartial:ViewComponent
    {
        private readonly IAboutService _AboutService;
        public _DefaultAboutComponentpartial(IAboutService AboutService)
        {
            _AboutService = AboutService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _AboutService.GetAllAboutAsync();
            return View(values);
        }
    }
}
