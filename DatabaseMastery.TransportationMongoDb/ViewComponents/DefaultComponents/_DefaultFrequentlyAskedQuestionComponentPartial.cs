using DatabaseMastery.TransportationMongoDb.Services.QuestionServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportationMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultFrequentlyAskedQuestionComponentPartial:ViewComponent
    {
        private readonly IQuestionService _QuestionService;
        public _DefaultFrequentlyAskedQuestionComponentPartial(IQuestionService QuestionService)
        {
            _QuestionService = QuestionService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _QuestionService.GetAllQuestionAsync();
            return View(values);
        }
    }
}
