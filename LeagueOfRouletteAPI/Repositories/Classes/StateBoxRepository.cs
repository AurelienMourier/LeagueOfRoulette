using LeagueOfRouletteAPI.Context;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Classes
{
    public class StateBoxRepository : IStateBoxRepository
    {
        private readonly LORContext _context;
        public StateBoxRepository(LORContext context)
        {
            _context = context;
        }
        public void CreateStateBox(StateBox stateBox)
        {
            _context.StateBox.Add(stateBox);
            _context.SaveChanges();
        }

        public void DeleteStateBox(int stateBoxId)
        {
            StateBox stateBox = _context.StateBox.Find(stateBoxId);

            _context.StateBox.Remove(stateBox);
            _context.SaveChanges();
        }

        public StateBox GetStateBoxById(int stateBoxId)
        {
            return _context.StateBox.Find(stateBoxId);
        }

        public IEnumerable<StateBox> GetStatesBox()
        {
            return _context.StateBox.ToArray();
        }

        public void UpdateStateBox(int stateBoxId, StateBox stateBox)
        {
            StateBox stateBoxEntity = _context.StateBox.Find(stateBoxId);

            stateBoxEntity.State = stateBox.State;

            _context.StateBox.Update(stateBoxEntity);
            _context.SaveChanges();
        }
    }
}
