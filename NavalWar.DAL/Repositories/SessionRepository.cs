using Microsoft.EntityFrameworkCore;
using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;
using NavalWar.DTO;

namespace NavalWar.DAL.Repositories
{
    internal class SessionRepository : ISessionRepository
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
            try
            {
                return _context.Sessions.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertSession(Session session)
        {
            try
            {
                _context.Sessions.Add(session);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteSession(int id)
        {
            try
            {
                Session session = _context.Sessions.Find(id);
                _context.Sessions.Remove(session);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateSession(Session session)
        {
            try
            {
                _context.Entry(session).State = EntityState.Modified;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        IEnumerable<SessionDTO> ISessionRepository.GetSessions()
        {
            throw new NotImplementedException();
        }

        SessionDTO ISessionRepository.GetSessionById(int id)
        {
            throw new NotImplementedException();
        }

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
