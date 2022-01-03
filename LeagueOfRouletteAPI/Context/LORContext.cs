using LeagueOfRouletteAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Context
{
    public class LORContext : IdentityDbContext<User, Role, Guid>
    {
        public LORContext(DbContextOptions<LORContext> options): base(options)
        {

        }

        public DbSet<Backpack> Backpack { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<BackpackCard> BackpackCard { get; set; }
        public DbSet<RarityCard> RarityCard { get; set; }
        public DbSet<StatCard> StatCard { get; set; }
        public DbSet<TypeCard> TypeCard { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BackpackCard>()
                .HasOne(bpc => bpc.Backpack)
                .WithMany(bp => bp.BackpackCards)
                .HasForeignKey(bpc => bpc.BackpackId);

            modelBuilder.Entity<BackpackCard>()
                .HasOne(bpc => bpc.Card)
                .WithMany(c => c.BackpackCards)
                .HasForeignKey(bpc => bpc.CardId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
