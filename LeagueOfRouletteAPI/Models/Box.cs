using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Models
{
    public class Box
    {
        public int BoxId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public ICollection<CardBox> CardBoxs { get; set; }
        public int Level { get; set; }
        public int StateBoxId { get; set; }
        [ForeignKey("StateBoxId")]
        public StateBox StateBox { get; set; }
    }
}
