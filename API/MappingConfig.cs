

using API.Models;
using API.Models.Dto;
using AutoMapper;

namespace API
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {

            CreateMap<Cliente, ClienteDto>();
            CreateMap<ClienteDto, Cliente>();

            CreateMap<Cliente, ClienteCreateDto>().ReverseMap();
            CreateMap<Cliente, ClienteUpdateDto>().ReverseMap();
        }
    }
}
