using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;

namespace NavalWar.Business
{
    public class GameService : IGameService
    {
        private static Session _session = new Session();
        private readonly IPlayerRepository _playerRepository;
        public GameService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public GameArea GetArea()
        {
            return _area;
        }
    }
}