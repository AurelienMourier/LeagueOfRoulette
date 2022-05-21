using AutoMapper;
using LeagueOfRouletteAPI.DTOs;
using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Profiles
{
    public class BackpackCardProfile : Profile
    {
        public BackpackCardProfile()
        {
            CreateMap<BackpackCardDto, BackpackCard>();
        }
    }
}
