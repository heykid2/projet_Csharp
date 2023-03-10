using NavalWar.Utils;

namespace NavalWar.DTO
{
    
    public class SessionDTO
    {
        public int? SessionId { get; set; }
        
        public int? Player1Id { get; set; }

        public int? Player2Id { get; set; }

        public int? WinnerPlayerId { get; set; }

        public SessionStatus? Status { get; set; }

        public int? CurrentPlayer { get; set; }


        public SessionDTO(int? sessionId, int? player1Id, int? player2Id, int? winnerPlayerId, SessionStatus? status, int? currentPlayer)
        {
            SessionId = sessionId;
            Player1Id = player1Id;
            Player2Id = player2Id;
            WinnerPlayerId = winnerPlayerId;
            Status = status ?? SessionStatus.Waiting;
            CurrentPlayer = currentPlayer;
        }
    }
}
