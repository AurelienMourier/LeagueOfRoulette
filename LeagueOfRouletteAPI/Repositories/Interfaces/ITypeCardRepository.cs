using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Interfaces
{
    public interface ITypeCardRepository
    {
        IEnumerable<TypeCard> GetTypeCards();
        TypeCard GetTypeCardById(int typeCardId);
        void CreateTypeCard(TypeCard typeCard);
        void DeleteTypeCard(int typeCardId);
        void UpdateTypeCard(int typeCardId, TypeCard typeCard);
    }
}
