using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Models
{
    public class Backpack
    {
        public int BackpackId { get; set; }
        public ICollection<BackpackCard> BackpackCards { get; set; }
    }
}
