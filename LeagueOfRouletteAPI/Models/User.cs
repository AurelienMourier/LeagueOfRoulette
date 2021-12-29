using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Models
{
    public class User : IdentityUser<Guid>
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int BackpackId { get; set; }
        [ForeignKey("BackpackId")]
        public Backpack Backpack { get; set; }
    }
}
