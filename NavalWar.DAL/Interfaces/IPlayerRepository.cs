using NavalWar.DTO.WebDTO;

namespace NavalWar.DAL.Interfaces
{
    public interface IPlayerRepository : IDisposable
    {
        public IEnumerable<PlayerDTO> GetPlayers();
        public PlayerDTO GetPlayerById(int id);
        public void InsertPlayer(PlayerDTO player);
        public void DeletePlayer(int id);
        public void UpdatePlayer(PlayerDTO player);
        public void Save();
    }
}
