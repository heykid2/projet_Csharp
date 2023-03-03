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

        //TODO : 
        public SessionDTO GetSession(int id)
        {
            return null;
        }
    }
}