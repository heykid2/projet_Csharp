using NavalWar.DAL.Models;
using NavalWar.DTO;
using NavalWar.Utils;

namespace NavalWar.DAL.Interfaces
{
    public interface ISessionService
    {
        List<SessionDTO> GetSessions();

        SessionDTO GetSessionById(int id);

        SessionStatus GetSessionStatus(int id);

        SessionDTO GetUserSession(int userId, int sessionId);

        public SessionDTO GetAvailableSession();

        void AddSession(SessionDTO session);

        void UpdateSession(SessionDTO session);

        void DeleteSession(int session);
    }
}
