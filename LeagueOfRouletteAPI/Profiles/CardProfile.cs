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
               .ForMember(dest => dest.StatCard, opt => opt.MapFrom(src => src.StatCard));
        }
    }
}
