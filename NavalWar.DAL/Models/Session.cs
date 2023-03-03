using System.ComponentModel.DataAnnotations;

namespace NavalWar.DAL.Models
{
    public enum SessionStatus
    {
        Waiting,        //attente de tous les joueurs
        Placement,      //placement des bateaux
        Ingame,         //en cours de partie
        Ended           //finie
    }

    public class Session
    {
        [Key]
        public int? SessionId { get; set; }

        public int Player1Id { get; set; }
        
        public int Player2Id { get; set; }

        public int? WinnerPlayerId { get; set; }

        public SessionStatus Status { get; set; }

        public Session(int? id, Player player1, Player player2)
        {
            ID = id;
            Player1 = player1;
            Player2 = player2;
            Status = SessionStatus.Waiting;
        }
    }
}
