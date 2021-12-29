using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Interfaces
{
    public interface ICardRepository
    {
        IEnumerable<Card> GetCards();
        Card GetCardById(int cardId);
        void CreateCard(Card card);
        void DeleteCard(int cardId);
        void UpdateCard(int cardId, Card card);
    }
}
