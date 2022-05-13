using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<BackpackCard>? BackpackCards { get; set; }
        public ICollection<CardBox> CardBoxs { get; set; }
        public int RarityCardId { get; set; }
        [ForeignKey("RarityCardId")]
        public RarityCard RarityCard { get; set; }
        public int StatCardId { get; set; }
        [ForeignKey("StatCardId")]
        public StatCard StatCard { get; set; }
        public int TypeCardId { get; set; }
        [ForeignKey("TypeCardId")]
        public TypeCard TypeCard { get; set; }
    }
}
