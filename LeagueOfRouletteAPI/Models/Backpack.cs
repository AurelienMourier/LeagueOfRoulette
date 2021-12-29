using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Models
{
    public class Backpack
    {
        public int Id { get; set; }
        public ICollection<BackpackCard> BackpackCard { get; set; }
    }
}
