using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Interfaces
{
    public interface IRarityCardRepository
    {
        IEnumerable<RarityCard> GetRarityCards();
        RarityCard GetRarityCardById(int rarityCardId);
        void CreateRarityCard(RarityCard rarityCard);
        void DeleteRarityCard(int rarityCardId);
        void UpdateRarityCard(int rarityCardId, RarityCard rarityCard);
    }
}
