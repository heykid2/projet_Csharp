using Microsoft.EntityFrameworkCore;
using NavalWar.DAL.Models;

namespace NavalWar.DAL.Repositories
{
    public class PlayerRepository
    {
        private NavalContext _context;
        private bool disposed = false;

        public PlayerRepository(NavalContext _context)
        {
            _context = _context;
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _context.Players.ToList();
        }

        public Player GetPlayerByID(int id)
        {
            return _context.Players.Find(id);
        }

        public void InsertPlayer(Player Player)
        {
            _context.Players.Add(Player);
        }

        public void DeletePlayer(int id)
        {
            Player Player = _context.Players.Find(id);
            _context.Players.Remove(Player);
        }

        public void UpdatePlayer(Player Player)
        {
            _context.Entry(Player).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
