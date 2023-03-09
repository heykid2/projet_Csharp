using NavalWar.DAL.Models;
using NavalWar.DTO;
using NavalWar.Utils;

namespace NavalWar.DAL.Interfaces
{
    public interface ISessionService
    {
        List<SessionDTO> GetSessions();

        SessionDTO GetSessionById(int id);

        SessionStatus? GetSessionStatus(int id);

        IEnumerable<SessionDTO> GetUserSessions(string userName);

        void AddSession(SessionDTO session);

        void UpdateSession(SessionDTO session);

        void DeleteSession(int session);
    }
}
