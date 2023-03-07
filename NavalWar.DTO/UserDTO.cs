namespace NavalWar.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserDTO(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
