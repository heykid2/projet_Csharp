namespace NavalWar.DTO
{
    public class PlayerDTO
    {
        public int PlayerId { get; set; }

        public UserDTO User { get; set; }

        public SessionDTO Session { get; set; }

        public List<ShipDTO> Ships { get; set; }

        public List<ShotDTO> Shots { get; set; }

        public bool IsReady { get; set; }

        public PlayerDTO(int playerId, UserDTO user, SessionDTO session, List<ShipDTO> ships, List<ShotDTO> shots, bool isReady)
        {
            PlayerId = playerId;
            User = user;
            Session = session;
            Ships = ships;
            Shots = shots;
            IsReady = isReady;
        }
    }
}
