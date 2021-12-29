using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Interfaces
{
    public interface IStatCardRepository
    {
        IEnumerable<StatCard> GetStatCards();
        StatCard GetStatCardById(int statCardId);
        void CreateStatCard(StatCard statCard);
        void DeleteStatCard(int statCardId);
        void UpdateStatCard(int statCardId, StatCard statCard);
    }
}
