using CarWorkshop.Domain.Interfaces;
using CarWorkshop.Infrastrucuture.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.Infrastrucuture.Repositories
{
    public class CarWorkshopRepository : ICarWorkshopRepository
    {
        private readonly CarWorkshopDbContext _dbContext;

        public CarWorkshopRepository(CarWorkshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Domain.Entities.CarWorkshop carWorkshop)
        {
            _dbContext.Add(carWorkshop);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Domain.Entities.CarWorkshop?> GetByNameAsync(string name)
            => await _dbContext.CarWorkshops.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());

    }
}
