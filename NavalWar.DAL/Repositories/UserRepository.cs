using Microsoft.EntityFrameworkCore;
using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;

namespace NavalWar.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly NavalContext _context;

        public UserRepository(NavalContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User? GetUserByUsername(string username)
        {      
            return _context.Users.Find(username);
        }

        public void InsertUser(User user)
        {
            _context.Users.Add(user);
            Save();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                Save();
            }
        }

        public void UpdateUser(User user)
        {
            _context.Update(user);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
