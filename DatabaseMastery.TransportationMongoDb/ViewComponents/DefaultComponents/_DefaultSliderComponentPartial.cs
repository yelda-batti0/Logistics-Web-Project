using DatabaseMastery.TransportationMongoDb.Services.SliderServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportationMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultSliderComponentPartial:ViewComponent
    {
        private readonly ISliderService _sliderService;
        public _DefaultSliderComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _sliderService.GetAllSliderAsync();
            return View(values);
        }
    }
}
