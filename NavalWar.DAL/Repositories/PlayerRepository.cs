using Microsoft.EntityFrameworkCore;
using NavalWar.DAL.Models;
using NavalWar.DAL.Interfaces;

namespace NavalWar.DAL.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly NavalContext _context;

        public PlayerRepository(NavalContext context)
        {
            _context = context;
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _context.Players.ToList();
        }

        public Player GetPlayerById(int? id)
        {
            return (id == null) ? _context.Players.Find(id) : null;
        }

        public int InsertPlayer(Player player)
        {
            _context.Players.Add(player);
            Save();
            return player.PlayerId;
        }

        public void DeletePlayer(int id)
        {
            //Player Player = _context.Players.Find(id);
            //_context.Players.Remove(Player);
        }

        public void UpdatePlayer(Player player)
        {
            _context.Update(player);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        
    }
}
