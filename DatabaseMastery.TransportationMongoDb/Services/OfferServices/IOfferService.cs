using DatabaseMastery.TransportationMongoDb.Dtos.OfferDtos;

namespace DatabaseMastery.TransportationMongoDb.Services.OfferServices
{
    public interface IOfferService
    {
        Task<List<ResultOfferDto>> GetAllOfferAsync();

        Task CreateOfferAsync(CreateOfferDto createOfferDto);
        Task UpdateOfferAsync(UpdateOfferDto updateOfferDto);

        Task<GetOfferByIdDto> GetOfferByIdAsync(string id);

        Task DeleteOfferAsync(string id);
    }
}
