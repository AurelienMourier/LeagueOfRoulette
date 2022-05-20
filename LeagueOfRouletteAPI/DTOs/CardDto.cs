using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.DTOs
{
    public class CardDto
    {
        public int CardId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string RarityCard { get; set; }
        public string TypeCard { get; set; }
        public int StatCardId { get; set; }
        public int StatCardAD { get; set; }
    }
}
