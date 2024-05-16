using Cargo.Data.Models;
using Cargo.Data.Repositories.Cargo;

namespace Cargo.Service.CargoService
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository _cargoRepository;
        public CargoService(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }
        public async Task<CargoEntity> DeleteAsync(int id)
        {
            return await _cargoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CargoEntity>> GetAllAsync()
        {
            return await _cargoRepository.GetAllAsync();
        }

        public async Task<CargoEntity> GetByIdAsync(int id)
        {
            return await _cargoRepository.GetByIdAsync(id);
        }

        public async Task<CargoEntity> PostAsync(CargoEntity Entity)
        {
            return await _cargoRepository.PostAsync(Entity);
        }

        public async Task<CargoEntity> PutAsync(CargoEntity Entity)
        {
            return await _cargoRepository.PutAsync(Entity);
        }
    }
}
