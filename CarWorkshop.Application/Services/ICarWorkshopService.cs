namespace CarWorkshop.Application.Services
{
    public interface ICarWorkshopService
    {
        Task CreateAsync(Domain.Entities.CarWorkshop carWorkshop);
    }
}