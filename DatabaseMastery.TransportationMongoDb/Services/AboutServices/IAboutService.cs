using DatabaseMastery.TransportationMongoDb.Dtos.AboutDtos;

namespace DatabaseMastery.TransportationMongoDb.Services.AboutServices
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAboutAsync();

        Task CreateAboutAsync(CreateAboutDto createAboutDto);
        Task UpdateAboutAsync(UpdateAboutDto updateAboutDto);

        Task<GetAboutByIdDto> GetAboutByIdAsync(string id);

        Task DeleteAboutAsync(string id);
    }
}
