using NavalWar.DAL.Models;
using NavalWar.DAL.Interfaces;

namespace NavalWar.DAL.Repositories
{
    public class ShotRepository : IShotRepository
    {
        private readonly NavalContext _context;

        public ShotRepository(NavalContext context)
        {
            _context = context;
        }

        public Shot? GetShotById(int shotId)
        {
            return _context.Shots.Find(shotId);
        }

        public void InsertShot(Shot shot)
        {
            _context.Shots.Add(shot);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
