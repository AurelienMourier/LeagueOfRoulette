using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Models
{
    public class BackpackCard
    {
        public int BackpackCardId { get; set; }
        public int BackpackId { get; set; }
        [ForeignKey("BackpackId")]
        public Backpack Backpack { get; set; }
        public int CardId { get; set; }
        [ForeignKey("CardId")]
        public Card Card { get; set; }
    }
}
