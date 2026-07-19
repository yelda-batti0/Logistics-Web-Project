using DatabaseMastery.TransportationMongoDb.Dtos.SliderDtos;

namespace DatabaseMastery.TransportationMongoDb.Services.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();

        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);

        Task<GetSliderByIdDto> GetSliderByIdAsync(string id);

        Task DeleteSliderAsync(string id);
    }
}
