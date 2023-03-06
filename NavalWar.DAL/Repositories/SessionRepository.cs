using Microsoft.EntityFrameworkCore;
using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;
using NavalWar.DTO;

namespace NavalWar.DAL.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private readonly NavalContext _context;

        public SessionRepository(NavalContext context)
        {
            _context = context;
        }

        public IEnumerable<Session> GetSessions()
        {
            return _context.Sessions.ToList();
        }

        public Session GetSessionById(int id)
        {
            return _context.Sessions.Find(id);
        }

        public Session GetUserSession(int userId, int sessionId)
        {
            return null;//_context.Sessions.Find();
        }

        public void InsertSession(Session session)
        {
            _context.Sessions.Add(session);
            _context.SaveChanges();
        }

        public void DeleteSession(int id)
        {
            Session session = _context.Sessions.Find(id);
            _context.Sessions.Remove(session);
            _context.SaveChanges();
        }

        public void UpdateSession(Session session)
        {
            _context.Sessions.Update(session);
            _context.SaveChanges();
        }

        //IEnumerable<SessionDTO> ISessionRepository.GetSessions()
        //{
        //    throw new NotImplementedException();
        //}

        //SessionDTO ISessionRepository.GetSessionById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public void InsertSession(SessionDTO session)
        {
            throw new NotImplementedException();
        }

        public void UpdateSession(SessionDTO session)
        {
            throw new NotImplementedException();
        }
    }
}
