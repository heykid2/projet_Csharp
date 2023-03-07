using Microsoft.EntityFrameworkCore;
using NavalWar.DAL.Models;
using NavalWar.DAL.Interfaces;

namespace NavalWar.DAL.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly NavalContext _context;

        public PlayerRepository(NavalContext _context)
        {
            _context = _context;
        }

        public IEnumerable<Player> GetPlayers()
        {
            //return _context.Players.ToList();
            return null;
        }

        public Player GetPlayerById(int? id)
        {
            return (id == null) ? _context.Players.Find(id) : null;
        }

        public void InsertPlayer(Player Player)
        {
            //_context.Players.Add(Player);
        }

        public void DeletePlayer(int id)
        {
            //Player Player = _context.Players.Find(id);
            //_context.Players.Remove(Player);
        }

        public void UpdatePlayer(Player Player)
        {
            //_context.Entry(Player).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        
    }
}
