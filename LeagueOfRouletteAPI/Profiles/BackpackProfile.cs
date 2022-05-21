using AutoMapper;
using LeagueOfRouletteAPI.DTOs;
using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Profiles
{
    public class BackpackProfile : Profile
    {
        public BackpackProfile()
        {
            CreateMap<CreateBackpackDto, Backpack>();

            CreateMap<Backpack, BackpackDto>();
        }
    }
}
