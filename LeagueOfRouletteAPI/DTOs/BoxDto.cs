using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.DTOs
{
    public class BoxDto
    {
        public int BoxId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public ICollection<int> Cards { get; set; }
        public int Level { get; set; }
    }
}
