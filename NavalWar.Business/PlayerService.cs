using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;
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
            List<PlayerDTO> players = new List<PlayerDTO>() /*= _playerRepository.GetPlayers()*/;
            return players;
        }
    }
}
