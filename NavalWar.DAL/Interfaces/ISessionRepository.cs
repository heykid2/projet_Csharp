using NavalWar.DTO;

namespace NavalWar.DAL.Interfaces
{
    public interface ISessionRepository
    {
        IEnumerable<SessionDTO> GetSessions();
        SessionDTO GetSessionById(int id);
        void InsertSession(SessionDTO session);
        void DeleteSession(int id);
        void UpdateSession(SessionDTO session);
        void Save();
    }
}
