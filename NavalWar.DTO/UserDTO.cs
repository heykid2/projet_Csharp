namespace NavalWar.DTO
{
    public class UserDTO
    {
        public string? Name { get; set; }

        public List<PlayerDTO> Players { get; set; }

        public UserDTO(string? name, List<PlayerDTO> players)
        {
            Name = name;
            Players = players;
        }
    }
}
