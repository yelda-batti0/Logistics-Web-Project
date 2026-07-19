using DatabaseMastery.TransportationMongoDb.Dtos.QuestionDtos;

namespace DatabaseMastery.TransportationMongoDb.Services.QuestionServices
{
    public interface IQuestionService
    {
        Task<List<ResultQuestionDto>> GetAllQuestionAsync();

        Task CreateQuestionAsync(CreateQuestionDto createQuestionDto);
        Task UpdateQuestionAsync(UpdateQuestionDto updateQuestionDto);

        Task<GetQuestionByIdDto> GetQuestionByIdAsync(string id);

        Task DeleteQuestionAsync(string id);
    }
}
