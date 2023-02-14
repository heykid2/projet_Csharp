using System.ComponentModel.DataAnnotations;

namespace NavalWar.DAL.Models
{
    public class Session
    {
        [Key]
        public int? ID { get; set; }

        public Player Player1 { get; set; }
        
        public Player Player2 { get; set; }

        public Player? Winner { get; set; }

        public Session(int? id, Player player1, Player player2)
        {
            ID = id;
            Player1 = player1;
            Player2 = player2;
        }
    }
}
