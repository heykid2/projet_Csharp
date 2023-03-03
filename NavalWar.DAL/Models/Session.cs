using System.ComponentModel.DataAnnotations;

namespace NavalWar.DAL.Models
{
    public class Session
    {
        [Key]
        public int? SessionId { get; set; }

        public int Player1Id { get; set; }
        
        public int Player2Id { get; set; }

        public int? WinnerPlayerId { get; set; }

        public Session(int? sessionId, int player1Id, int player2Id)
        {
            SessionId = sessionId;
            Player1Id = player1Id;
            Player2Id = player2Id;
        }
    }
}
