using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;

namespace NavalWar.DAL.Repositories
{
    public class ShipRepository : IShipRepository
    {
        private readonly NavalContext _context;

        public ShipRepository(NavalContext context)
        {
            _context = context;
        }

        public void InsertShip(Ship ship)
        {
            _context.Ships.Add(ship);
            Save();
        }

        public void UpdateShip(Ship ship)
        {
            _context.Ships.Update(ship);
            Save();
        }

        public void DeleteShip(int id)
        {
            Ship ship = _context.Ships.Find(id);
            _context.Ships.Remove(ship);
            Save();
        }

        public Ship GetShipById(int id)
        {
            return _context.Ships.Find(id);
        }

        public IEnumerable<Ship> GetShips()
        {
            return _context.Ships.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
