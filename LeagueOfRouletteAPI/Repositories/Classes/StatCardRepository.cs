using LeagueOfRouletteAPI.Context;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Classes
{
    public class StatCardRepository : IStatCardRepository
    {
        private readonly LORContext _context;
        public StatCardRepository(LORContext context)
        {
            _context = context;
        }
        public void CreateStatCard(StatCard statCard)
        {
            _context.StatCard.Add(statCard);
            _context.SaveChanges();
        }

        public void DeleteStatCard(int statCardId)
        {
            StatCard statCard = _context.StatCard.Find(statCardId);

            _context.StatCard.Remove(statCard);
            _context.SaveChanges();
        }

        public StatCard GetStatCardById(int statCardId)
        {
            return _context.StatCard.Find(statCardId);
        }

        public IEnumerable<StatCard> GetStatCards()
        {
            return _context.StatCard.ToArray();
        }

        public void UpdateStatCard(int statCardId, StatCard statCard)
        {
            StatCard statCardEntity = _context.StatCard.Find(statCardId);

            statCardEntity.AD = statCard.AD;
            statCardEntity.AP = statCard.AP;
            statCardEntity.AR = statCard.AR;
            statCardEntity.AS = statCard.AS;
            statCardEntity.MR = statCard.MR;
            statCardEntity.MV = statCard.MV;

            _context.StatCard.Update(statCardEntity);
            _context.SaveChanges();
        }
    }
}
