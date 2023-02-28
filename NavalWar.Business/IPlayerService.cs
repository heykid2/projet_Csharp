using NavalWar.DTO;

namespace NavalWar.Business
{
    public interface IPlayerService
    {
        void AddPlayer(PlayerDTO user);
        List<PlayerDTO> GetPlayers();
    }
}
