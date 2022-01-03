using LeagueOfRouletteAPI.Context;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Classes
{
    public class BackpackRepository : IBackpackRepository
    {
        private readonly LORContext _context;
        public BackpackRepository(LORContext context)
        {
            _context = context;
        }
        public void CreateBackpack(Backpack backpack)
        {
            _context.Backpack.Add(backpack);
            _context.SaveChanges();
        }

        public void DeleteBackpack(int backpackId)
        {
            Backpack backpack = _context.Backpack.Find(backpackId);
            _context.Backpack.Remove(backpack);
            _context.SaveChanges();
        }

        public Backpack GetBackpackById(int backpackId)
        {
            Backpack backpack = _context.Backpack.Find(backpackId);
            return backpack;
        }

        public IEnumerable<Backpack> GetBackpacks()
        {
            return _context.Backpack.ToList();
        }

        public void UpdateBackpack(int backpackId, Backpack backpack)
        {
            Backpack backpackEntity = _context.Backpack.Find(backpackId);
            backpackEntity.BackpackCards = backpack.BackpackCards;

            _context.Backpack.Update(backpackEntity);
            _context.SaveChanges();
        }
    }
}
