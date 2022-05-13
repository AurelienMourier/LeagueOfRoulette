using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.DTOs
{
    public class CreateCardDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int RarityCardId { get; set; }
        public int StatCardId { get; set; }
        public int TypeCardId { get; set; }
    }
}
