

using System.Diagnostics;
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
            CreateMap<Raza, RazaDto>().ReverseMap();

            CreateMap<Raza, RazaCreateDto>().ReverseMap();
            CreateMap<Raza, RazaUpdateDto>().ReverseMap();

            CreateMap<Cliente, ClienteCreateDto>().ReverseMap();
            CreateMap<Cliente, ClienteUpdateDto>().ReverseMap();
        }
    }
}
