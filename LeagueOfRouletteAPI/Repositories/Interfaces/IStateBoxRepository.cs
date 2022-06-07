using LeagueOfRouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Interfaces
{
    public interface IStateBoxRepository
    {
        IEnumerable<StateBox> GetStatesBox();
        StateBox GetStateBoxById(int stateBoxId);
        void CreateStateBox(StateBox stateBox);
        void DeleteStateBox(int stateBoxId);
        void UpdateStateBox(int stateBoxId, StateBox stateBox);
    }
}
