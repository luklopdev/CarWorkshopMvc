using CarWorkshop.Application.CarWorkshop;

namespace CarWorkshop.Application.Services
{
    public interface ICarWorkshopService
    {
        Task CreateAsync(CarWorkshopDto carWorkshopDto);
    }
}