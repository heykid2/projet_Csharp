using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;
using NavalWar.DTO;
using NavalWar.DAL.ExtensionMethods;

namespace NavalWar.Business
{
    public class SessionService : ISessionService
    {
        private readonly ISessionRepository _sessionRepository;
        
        public SessionService(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        public List<SessionDTO> GetSessions()
        {
            List<Session> sessions = (List<Session>)_sessionRepository.GetSessions();
            return sessions.Select(s => s.ToDTO()).ToList();
        }

        public SessionDTO GetSessionById(int id)
        {
            Session session = (Session)_sessionRepository.GetSessionById(id);
            return session.ToDTO();
        }

        public SessionStatus GetSessionStatus(int id)
        {
            Session session = (Session)_sessionRepository.GetSessionById(id);
            return session.Status;
        }

        public SessionDTO GetUserSession(int userId, int sessionId)
        {
            Session session = (Session)_sessionRepository.GetUserSession(userId, sessionId);
            return session.ToDTO();
        }

        public SessionDTO GetAvailableSession()
        {
            Session session = _sessionRepository.GetAvailableSession();
            return session == null ? session.ToDTO() : null;
        }

        public void AddSession(SessionDTO session)
        {
            _sessionRepository.InsertSession(session.ToModel());
        }

        public void UpdateSession(SessionDTO session)
        {
            _sessionRepository.UpdateSession(session.ToModel());
        }

        public void DeleteSession(int session)
        {
            _sessionRepository.DeleteSession(session);
        }
    }
}