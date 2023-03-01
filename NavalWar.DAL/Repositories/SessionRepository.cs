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
            //return _context.Sessions.ToList();
            return null;
        }

        public Session GetSessionById(int id)
        {
            //return _context.Sessions.Find(id);
            return null;
        }

        public void InsertSession(Session session)
        {
            //_context.Sessions.Add(session);
        }

        public void DeleteSession(int id)
        {
            //Session session = _context.Sessions.Find(id);
            //_context.Sessions.Remove(session);
        }

        public void UpdateSession(Session session)
        {
            //_context.Entry(session).State = EntityState.Modified;
        }

        public void Save()
        {
            //_context.SaveChanges();
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
