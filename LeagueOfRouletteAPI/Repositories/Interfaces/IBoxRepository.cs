using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Interfaces
{
    public interface IBoxRepository
    {
        IEnumerable<Box> GetBoxes();
        Box GetBoxById(int boxId);
        void CreateBox(Box box);
        void DeleteBox(int boxId);
        void UpdateBox(int boxId, Box box);
    }
}