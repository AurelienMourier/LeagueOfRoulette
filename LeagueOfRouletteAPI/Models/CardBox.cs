using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Models
{
    public class CardBox
    {
        public int CardBoxId { get; set; }
        public int CardId { get; set; }
        [ForeignKey("CardId")]
        public Card Card { get; set; }
        public int BoxId { get; set; }
        [ForeignKey("BoxId")]
        public Box Box { get; set; }
    }
}
