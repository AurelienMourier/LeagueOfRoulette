using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<BackpackCard> BackpackCard { get; set; }
        public int RarityCardId { get; set; }
        [ForeignKey("RarityCardId")]
        public RarityCard Rarity { get; set; }
        public int StatCardId { get; set; }
        [ForeignKey("StatCardId")]
        public StatCard Stat { get; set; }
        public int TypeCardId { get; set; }
        [ForeignKey("TypeCardId")]
        public TypeCard Type { get; set; }
    }
}
