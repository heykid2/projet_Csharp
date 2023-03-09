namespace NavalWar.DTO
{
    public class UserDTO
    {
        public string? UserName { get; set; }

        public UserDTO(string? userName)
        {
            UserName = userName;
        }
    }
}
