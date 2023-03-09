using NavalWar.DTO;

namespace NavalWar.Business
{
    public interface IPlayerService
    {
        void AddPlayer(PlayerDTO user);
        List<PlayerDTO> GetPlayers();
        PlayerDTO GetPlayerByKeys(UserDTO UserDTP, SessionDTO SessionDTP);
        int Fire(int playerId, ShotDTO shot);
        int UpdateShip(int playerId, int shipId, ShipDTO shipDto);
        void Ready(int playerId);
        int GetPlayerIdByKeys(UserDTO user, int sessionId);
    }
}
