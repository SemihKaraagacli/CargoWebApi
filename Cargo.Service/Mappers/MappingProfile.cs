using AutoMapper;

namespace Cargo.Service.Mappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Cargo.CargoRequestModel, Data.Models.CargoEntity>().ReverseMap();
            CreateMap<Models.Cargo.CargoResponseModel,Data.Models.CargoEntity>().ReverseMap();
        }
    }
}
