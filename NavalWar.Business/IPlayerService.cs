using NavalWar.DTO;

namespace NavalWar.Business
{
    public interface IPlayerService
    {
        void AddPlayer(PlayerDTO user);
        List<PlayerDTO> GetPlayers();
        PlayerDTO GetPlayerByKeys(UserDTO UserDTP, SessionDTO SessionDTP);
        int Fire(int playerId, int x, int y);
        int UpdateShip(int playerId, int shipId, int x, int y, bool isVertical);
    }
}
