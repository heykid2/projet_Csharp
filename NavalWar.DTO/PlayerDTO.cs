namespace NavalWar.DTO
{
    public class PlayerDTO
    {
        public int Id { get; set; }
        public UserDTO User { get; set; }

        public SessionDTO Session { get; set; }

        public List<ShipDTO> Ships { get; set; }

        public List<ShotDTO> Shots { get; set; }

        public PlayerDTO(int id, UserDTO newUser, SessionDTO newSession, List<ShipDTO> ships, List<ShotDTO> shots)
        {
            Id = id;
            Ships = ships;
            Shots = shots;
            User = newUser;
            Session = newSession;
        }
    }
}
