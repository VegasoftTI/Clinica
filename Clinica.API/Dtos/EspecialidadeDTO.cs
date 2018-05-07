using System;
using AutoMapper;
using Clinica.API.Models;
using Threenine.Map;

namespace Clinica.API.Dtos
{
    public class EspecialidadeDTO : ICustomMap
    {
        public int ID { get; set; }
        public string  Nome { get; set; }

        public void CustomMap(IMapperConfigurationExpression configuration)
        {
              configuration.CreateMap<Especialidade, EspecialidadeDTO>().ReverseMap();
              
                // .ForMember(dest => dest.FullName,
                //     opt => opt.MapFrom(src => string.Concat(src.FirstName, " ", src.LastName)))
                // .ForMember(dest => dest.Headline, opt => opt.MapFrom(src => src.TagLine))
                // .ForMember(dest => dest.Bio, opt => opt.MapFrom(src => src.Profile))
                // .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id) );
         
        }


        /*  public DateTime DataCriacao { get; set; }
         public bool Ativo { get; set; } */

    }
}