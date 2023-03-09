using NavalWar.DAL.Models;

namespace NavalWar.DAL.Interfaces
{
    public interface ISessionRepository
    {
        public IEnumerable<Session> GetSessions();
        public Session GetSessionById(int id);

        public IEnumerable<Session> GetSessionsByUser(string userId);
        public void InsertSession(Session session);
        public void DeleteSession(int id);
        public void UpdateSession(Session session);
    }
}
