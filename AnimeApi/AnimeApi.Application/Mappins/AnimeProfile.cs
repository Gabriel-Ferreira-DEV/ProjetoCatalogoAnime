using AnimeApi.Entities;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AnimeApi.DTOs.Mappins
{
    public class AnimeProfile : Profile
    {
        public AnimeProfile()
        {
            CreateMap<Anime, AnimeDTO>().ForMember(dest => dest.PlataformaNome,opt => opt.MapFrom(src => src.Plataforma.Nome));

        }
    }
}