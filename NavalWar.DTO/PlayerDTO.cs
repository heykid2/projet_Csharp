namespace NavalWar.DTO
{
    public class PlayerDTO
    {
        public UserDTO User { get; set; }

        public SessionDTO Session { get; set; }

        public List<ShipDTO> Ships { get; set; }

        public List<ShotDTO> Shots { get; set; }

        public PlayerDTO(UserDTO newUser, SessionDTO newSession)
        {
            User = newUser;
            Session = newSession;
        }
    }
}
