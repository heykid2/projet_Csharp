using NavalWar.DTO.Area;

namespace NavalWar.Business
{
    public class GameService : IGameService
    {
        private static GameArea _area = new GameArea();

        public GameArea GetArea()
        {
            return _area;
        }
    }
}