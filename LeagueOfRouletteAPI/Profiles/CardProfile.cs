using AutoMapper;
using LeagueOfRouletteAPI.DTOs;
using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Profiles
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<CreateCardDto, Card>();

            CreateMap<Card, CardDto>()
               .ForMember(dest => dest.RarityCard, opt => opt.MapFrom(src => src.RarityCard.Name))
               .ForMember(dest => dest.TypeCard, opt => opt.MapFrom(src => src.TypeCard.Name))
               .ForMember(dest => dest.StatCard, opt => opt.MapFrom(src => src.StatCard))
               .ForMember(dest => dest.StatCard.AD, opt => opt.MapFrom(src => src.StatCard.AD))
               .ForMember(dest => dest.StatCard.AP, opt => opt.MapFrom(src => src.StatCard.AP))
               .ForMember(dest => dest.StatCard.AR, opt => opt.MapFrom(src => src.StatCard.AR))
               .ForMember(dest => dest.StatCard.AS, opt => opt.MapFrom(src => src.StatCard.AS))
               .ForMember(dest => dest.StatCard.MR, opt => opt.MapFrom(src => src.StatCard.MR))
               .ForMember(dest => dest.StatCard.MV, opt => opt.MapFrom(src => src.StatCard.MV));
        }
    }
}
