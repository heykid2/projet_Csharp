using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;
using NavalWar.DTO;
using NavalWar.DAL.ExtensionMethods;
using NavalWar.Utils;

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

        public SessionStatus? GetSessionStatus(int id)
        {
            Session session = (Session)_sessionRepository.GetSessionById(id);
            return session.Status;
        }

        public IEnumerable<SessionDTO> GetUserSessions(string userName)
        {
            IEnumerable<Session> sessions = _sessionRepository.GetSessionsByUser(userName);
            List<SessionDTO> sessionsDTO = new();

            foreach (Session session in sessions)
            {
                sessionsDTO.Add(session.ToDTO());
            }

            return sessionsDTO;
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