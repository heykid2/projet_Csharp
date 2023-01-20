using NavalWar.DAL.Interfaces;
using NavalWar.DTO.WebDTO;

namespace NavalWar.DAL.Repositories
{
    internal class SessionRepository : ISessionRepository
    {
        private readonly NavalContext _context;

        public SessionRepository(NavalContext context)
        {
            _context = context;
        }

        public SessionDTO GetSessionById(int id)
        {
            try
            {
                var session = _context.Sessions.FirstOrDefault(x => x.ID == id);
                return session.ToDto();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
