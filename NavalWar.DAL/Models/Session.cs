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

        public Session(int? id, int player1, int player2)
        {
            SessionId = id;
            Player1Id = player1;
            Player2Id = player2;
            Status = SessionStatus.Waiting;
        }
    }
}
