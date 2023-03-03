using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;
using NavalWar.DTO;
using NavalWar.DAL.ExtensionMethods;

namespace NavalWar.Business
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public List<PlayerDTO> GetPlayers()
        {
            List<Player> players = (List<Player>)_playerRepository.GetPlayers();
            return players.Select(p => p.ToDTO()).ToList();
        }

        public void AddPlayer(PlayerDTO player)
        {
            _playerRepository.InsertPlayer(player.ToModel());
        }
        //TODO :
        public PlayerDTO GetPlayerByKeys(UserDTO UserDTP, SessionDTO SessionDTP)
        {
            return null;
        }
        //TODO :
        public bool ShotPlayer(PlayerDTO PlayerDTO, int x, int y)
        {
            return true;
        }

    }
}
