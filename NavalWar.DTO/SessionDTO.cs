

namespace NavalWar.DTO
{
    public class SessionDTO
    {
        public int? ID { get; set; }

        public PlayerDTO Player1 { get; set; }

        public PlayerDTO Player2 { get; set; }

        public PlayerDTO? Winner { get; set; }


        public SessionDTO(int? id, PlayerDTO player1, PlayerDTO player2)
        {
            ID = id;
            Player1 = player1;
            Player2 = player2;
        }
    }
}
