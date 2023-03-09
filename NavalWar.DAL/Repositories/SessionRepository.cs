using Microsoft.EntityFrameworkCore;
using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;

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

        public IEnumerable<Session> GetSessionsByUser(string userName)
        {
            List<Session> sessions = new();
            
            if (userName != null)
            {
                User user = _context.Users.Find(userName);
            
                IEnumerable<Player> players = user.Players;

                if (players != null)
                {
                    
                    foreach (Player player in players)
                    {
                        sessions.Add(player.Session);
                    }
                }
            }

            Save();
            
            return sessions;
        }

        public int InsertSession(Session session)
        {
            _context.Sessions.Add(session);
            Save();
            return session.SessionId ?? -1;
        }

        public void DeleteSession(int id)
        {
            Session session = _context.Sessions.Find(id);
            _context.Sessions.Remove(session);
            Save();
        }

        public void UpdateSession(Session session)
        {
            _context.Sessions.Update(session);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
