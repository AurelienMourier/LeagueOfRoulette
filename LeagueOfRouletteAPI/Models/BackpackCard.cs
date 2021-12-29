using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Models
{
    public class BackpackCard
    {
        public int id { get; set; }
        public int BackpackId { get; set; }
        public Backpack Backpack { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
