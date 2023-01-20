using NavalWar.DAL.Interfaces;
using NavalWar.DTO.Area;

namespace NavalWar.Business
{
    public class GameService : IGameService
    {
        private static GameArea _area = new GameArea();
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