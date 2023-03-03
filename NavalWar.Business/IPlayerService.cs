using NavalWar.DTO;

namespace NavalWar.Business
{
    public interface IPlayerService
    {
        void AddPlayer(PlayerDTO user);
        List<PlayerDTO> GetPlayers();
        PlayerDTO GetPlayerByKeys(UserDTO UserDTP, SessionDTO SessionDTP);
        bool ShotPlayer(PlayerDTO PlayerDTO, int x, int y);
    }
}
