using LeagueOfRouletteAPI.Context;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Classes
{
    public class TypeCardRepository : ITypeCardRepository
    {
        private readonly LORContext _context;

        public TypeCardRepository(LORContext context)
        {
            _context = context;
        }

        public void CreateTypeCard(TypeCard typeCard)
        {
            _context.TypeCard.Add(typeCard);
            _context.SaveChanges();
        }

        public void DeleteTypeCard(int typeCardId)
        {
            TypeCard typeCard = _context.TypeCard.Find(typeCardId);

            _context.TypeCard.Remove(typeCard);
            _context.SaveChanges();
        }

        public TypeCard GetTypeCardById(int typeCardId)
        {
            return _context.TypeCard.Find(typeCardId);
        }

        public IEnumerable<TypeCard> GetTypeCards()
        {
            return _context.TypeCard.ToList();
        }

        public void UpdateTypeCard(int typeCardId, TypeCard typeCard)
        {
            TypeCard typeCardEntity = _context.TypeCard.Find(typeCardId);

            typeCardEntity.Name = typeCard.Name;

            _context.TypeCard.Update(typeCardEntity);
            _context.SaveChanges();
        }
    }
}
