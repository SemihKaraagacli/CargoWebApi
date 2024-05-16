using AutoMapper;
using Cargo.Data.Models;
using Cargo.Service.CargoService;
using Cargo.Service.Models.Cargo;
using Microsoft.AspNetCore.Mvc;

namespace CargoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        private readonly ICargoService _cargoService;
        private readonly IMapper _mapper;
        public CargoController(ICargoService cargoService, IMapper mapper)
        {
            _cargoService = cargoService;
            _mapper= mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<CargoResponseModel>> GetAll()
        {
            var cargoAll=await _cargoService.GetAllAsync();
            return _mapper.Map<IEnumerable<CargoResponseModel>>(cargoAll);
        }
        [HttpGet("id")]
        public async Task<CargoResponseModel> GetById(int id)
        {
            var cargoById= await _cargoService.GetByIdAsync(id);
            return _mapper.Map<CargoResponseModel>(cargoById);
        }
        [HttpPost]
        public async Task<CargoResponseModel> Post([FromBody] CargoRequestModel requestModel)
        {
            var cargoPost = _mapper.Map<CargoEntity>(requestModel);
            var cargoPost1= await _cargoService.PostAsync(cargoPost);
            return _mapper.Map<CargoResponseModel>(cargoPost1);
        }
        [HttpPut]
        public async Task<CargoResponseModel> Put([FromBody] CargoRequestModel requestModel)
        {
            var cargoUpdate=_mapper.Map<CargoEntity>(requestModel);
            var cargoUpdate1= await _cargoService.PutAsync(cargoUpdate);
            return _mapper.Map<CargoResponseModel>(cargoUpdate1);
        }
        [HttpDelete("id")]
        public async Task<CargoResponseModel> DeleteById(int id)
        {
            var cargoDelete= await _cargoService.DeleteAsync(id);
            return _mapper.Map<CargoResponseModel>(cargoDelete);
        }
    }
}
