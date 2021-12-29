using LeagueOfRouletteAPI.Context;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Classes
{
    public class RarityCardRepository : IRarityCardRepository
    {
        private readonly LORContext _context;
        public RarityCardRepository(LORContext context)
        {
            _context = context;
        }
        public void CreateRarityCard(RarityCard rarityCard)
        {
            _context.RarityCard.Add(rarityCard);
            _context.SaveChanges();
        }

        public void DeleteRarityCard(int rarityCardId)
        {
            RarityCard rarityCard = _context.RarityCard.Find(rarityCardId);

            _context.RarityCard.Remove(rarityCard);
            _context.SaveChanges();
        }

        public RarityCard GetRarityCardById(int rarityCardId)
        {
            return _context.RarityCard.Find(rarityCardId);
        }

        public IEnumerable<RarityCard> GetRarityCards()
        {
            return _context.RarityCard.ToList();
        }

        public void UpdateRarityCard(int rarityCardId, RarityCard rarityCard)
        {
            RarityCard rarityCardEntity = _context.RarityCard.Find(rarityCardId);

            rarityCardEntity.Name = rarityCard.Name;

            _context.RarityCard.Update(rarityCardEntity);
            _context.SaveChanges();
        }
    }
}
