using System.ComponentModel.DataAnnotations;
using NavalWar.Utils;

namespace NavalWar.DAL.Models
{

    public class Session
    {
        [Key]
        public int? SessionId { get; set; }

        public int? Player1Id { get; set; }
        
        public int? Player2Id { get; set; }

        public int? WinnerPlayerId { get; set; }

        public SessionStatus Status { get; set; }

        public Session(int? id, int? player1, int? player2, int? winner, SessionStatus? status)
        {
            SessionId = id;
            Player1Id = player1;
            Player2Id = player2;
            WinnerPlayerId = winner;
            Status = status ?? SessionStatus.Waiting;
        }
    }
}
