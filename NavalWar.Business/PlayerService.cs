using NavalWar.DAL.Interfaces;
using NavalWar.DTO;

namespace NavalWar.Business
{
    public class PlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public List<PlayerDTO> GetPlayers()
        {
            List<Player> players = _playerRepository.GetPlayers();
            return players.ConvertAll<PlayerDTO>();
        }
    }
}
