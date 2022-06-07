using AutoMapper;
using LeagueOfRouletteAPI.DTOs;
using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Profiles
{
    public class BoxProfile : Profile
    {
        public BoxProfile()
        {
            CreateMap<BoxDto, Box>();

            CreateMap<Box, BoxDto>()
               .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.StateBox.State));
        }
    }
}
