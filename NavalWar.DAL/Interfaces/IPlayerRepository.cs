using NavalWar.DAL.Models;

namespace NavalWar.DAL.Interfaces
{
    public interface IPlayerRepository
    {
        public IEnumerable<Player> GetPlayers();
        public Player GetPlayerById(int id);
        public void InsertPlayer(Player player);
        public void DeletePlayer(int id);
        public void UpdatePlayer(Player player);
        public void Save();
    }
}
