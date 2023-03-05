using NavalWar.DAL.Models;

namespace NavalWar.DAL.Interfaces
{
    public interface ISessionRepository
    {
        public IEnumerable<Session> GetSessions();
        public Session GetSessionById(int id);

        public Session GetUserSession(int userId, int sessionId);
        public void InsertSession(Session session);
        public void DeleteSession(int id);
        public void UpdateSession(Session session);
        public void Save();
    }
}
