using LeagueOfRouletteAPI.Context;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Classes
{
    public class CardRepository : ICardRepository
    {
        private readonly LORContext _context;
        public CardRepository(LORContext context)
        {
            _context = context;
        }
        public void CreateCard(Card card)
        {
            _context.Card.Add(card);
            _context.SaveChanges();
        }

        public void DeleteCard(int cardId)
        {
            Card card = _context.Card.Find(cardId);

            _context.Card.Remove(card);
            _context.SaveChanges();
        }

        public Card GetCardById(int cardId)
        {
            return _context.Card.Find(cardId);
        }

        public IEnumerable<Card> GetCards()
        {
            return _context.Card.ToList();
        }

        public void UpdateCard(int cardId, Card card)
        {
            Card cardEntity = _context.Card.Find(cardId);

            cardEntity.BackpackCard = card.BackpackCard;
            cardEntity.Name = card.Name;
            cardEntity.Rarity = card.Rarity;
            cardEntity.RarityCardId = card.RarityCardId;
            cardEntity.Stat = card.Stat;
            cardEntity.StatCardId = card.StatCardId;
            cardEntity.Type = card.Type;
            cardEntity.TypeCardId = card.TypeCardId;
            cardEntity.ImageUrl = card.ImageUrl;

            _context.Card.Update(cardEntity);
            _context.SaveChanges();
        }
    }
}
