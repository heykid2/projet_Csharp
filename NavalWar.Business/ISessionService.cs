using NavalWar.DAL.Models;
using NavalWar.DTO;

namespace NavalWar.DAL.Interfaces
{
    public interface ISessionService
    {
        List<SessionDTO> GetSessions();

        SessionDTO GetSessionById(int id);

        SessionStatus GetSessionStatus(int id);

        SessionDTO GetUserSession(int userId, int sessionId);

        void AddSession(SessionDTO session);

        void UpdateSession(UserDTO user, SessionDTO session);

        void DeleteSession(int session);
    }
}
