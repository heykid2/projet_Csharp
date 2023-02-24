using NavalWar.DAL.Models;

namespace NavalWar.DAL.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetUsers();
        public User? GetUserByUsername(string username);
        public void InsertUser(User user);
        public void DeleteUser(int id);
        public void UpdateUser(User user);
        public void Save();
    }
}
