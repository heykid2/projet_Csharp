using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;
using NavalWar.DTO;
using NavalWar.DAL.ExtensionMethods;

namespace NavalWar.Business
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(UserDTO user)
        {
            _userRepository.InsertUser(user.ToModel());
        }

        public List<UserDTO> GetUsers()
        {
            List<User> users = (List<User>)_userRepository.GetUsers();
            return users.Select(p => p.ToDTO()).ToList();
        }

        public UserDTO GetUserByUsername(string username)
        {
            User user = _userRepository.GetUserByUsername(username);
            return user.ToDTO();
        }
    }
}
