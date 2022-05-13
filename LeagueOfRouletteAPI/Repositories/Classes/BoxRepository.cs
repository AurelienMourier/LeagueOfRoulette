using LeagueOfRouletteAPI.Context;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Repositories.Classes
{
    public class BoxRepository : IBoxRepository
    {
        private readonly LORContext _context;
        public BoxRepository(LORContext context)
        {
            _context = context;
        }

        public void CreateBox(Box box)
        {
            _context.Box.Add(box);
            _context.SaveChanges();
        }

        public void DeleteBox(int boxId)
        {
            Box box = _context.Box.Find(boxId);
            _context.Box.Remove(box);
            _context.SaveChanges();
        }

        public Box GetBoxById(int backpackId)
        {
            return _context.Box.Find(backpackId);
        }

        public IEnumerable<Box> GetBoxes()
        {
            return _context.Box.ToList();
        }

        public void UpdateBox(int backpackId, Box box)
        {
            Box boxEntity = _context.Box.Find(backpackId);

            boxEntity.Name = box.Name;
            boxEntity.Description = box.Description;
            boxEntity.Price = box.Price;
            boxEntity.CardBoxs = box.CardBoxs;

            _context.Box.Update(boxEntity);
        }
    }
}
