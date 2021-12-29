using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Interfaces
{
    public interface IBackpackRepository
    {
        IEnumerable<Backpack> GetBackpacks();
        Backpack GetBackpackById(int backpackId);
        void CreateBackpack(Backpack backpack);
        void DeleteBackpack(int backpackId);
        void UpdateBackpack(int backpackId, Backpack backpack);
    }
}
