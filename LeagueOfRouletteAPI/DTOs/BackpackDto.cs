using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.DTOs
{
    public class BackpackDto
    {
        public string Label { get; set; }
        public ICollection<BackpackCardDto> BackpackCards { get; set; }
    }
}
