namespace NavalWar.DTO
{
    public class PlayerDTO
    {
        public int IDUser { get; set; }

        public int IDSession { get; set; }

        public List<ShipDTO> Ships { get; set; }

        public List<ShotDTO> Shots { get; set; }

        public PlayerDTO(int idUser, int idSession)
        {
            IDUser = idUser;
            IDSession = idSession;
        }
    }
}
