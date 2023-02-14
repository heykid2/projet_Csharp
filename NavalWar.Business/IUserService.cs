using NavalWar.DTO;

namespace NavalWar.DAL.Interfaces
{
    public interface IUserService
    {
        void AddUser(UserDTO user);
        List<UserDTO> GetUsers();
    }
}
