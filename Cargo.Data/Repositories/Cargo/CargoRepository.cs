using Cargo.Data.Models;

namespace Cargo.Data.Repositories.Cargo
{
    public class CargoRepository : ICargoRepository
    {
        private readonly IGenericRepository<Models.CargoEntity> _genericRepository;
        public CargoRepository(IGenericRepository<Models.CargoEntity> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<CargoEntity> DeleteAsync(int id)
        {
            return await _genericRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CargoEntity>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<CargoEntity> GetByIdAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<CargoEntity> PostAsync(CargoEntity entity)
        {
            return await _genericRepository.PostAsync(entity);
        }

        public async Task<CargoEntity> PutAsync(CargoEntity entity)
        {
            return await _genericRepository.PutAsync(entity);
        }
    }
}
