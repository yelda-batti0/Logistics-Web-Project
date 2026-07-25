using DatabaseMastery.TransportationMongoDb.Dtos.ShipmentTrackingDtos;

namespace DatabaseMastery.TransportationMongoDb.Services.ShipmentTrackingServices
{
    public interface IShipmentTrackingService
    {
        Task<List<ResultShipmentTrackingDto>> GetAllTrackingsAsync(string trackingNumber);

        // Yeni hareket ekle
        Task CreateTrackingAsync(CreateShipmentTrackingDto createDto);

        // Belirli hareketi index ile getir (güncelleme formu için)
        Task<ResultShipmentTrackingDto> GetTrackingByIndexAsync(string trackingNumber, int index);

        // Hareketi güncelle
        Task UpdateTrackingAsync(UpdateShipmentTrackingDto updateDto);

        // Hareketi sil
        Task DeleteTrackingAsync(string trackingNumber, int index);
    }
}
