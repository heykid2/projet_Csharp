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

        public bool AddUser(UserDTO user)
        {
            bool result = false;
            User? existantUser = _userRepository.GetUserByUsername(user.UserName);
            if (existantUser == null)
            {
                _userRepository.InsertUser(user.ToModel());
                result = true;
            }
            return result;
        }

        public List<UserDTO> GetUsers()
        {
            List<User> users = (List<User>)_userRepository.GetUsers();
            return users.Select(p => p.ToDTO()).ToList();
        }

        public UserDTO GetUserByUsername(string username)
        {
            User user = _userRepository.GetUserByUsername(username);
            UserDTO userDTO = (user == null) ? new(null) : user.ToDTO();
            return userDTO;
        }
    }
}
