

namespace NavalWar.DTO
{
    public class SessionDTO
    {
        public int? ID { get; set; }

        public int Player1Id { get; set; }

        public int Player2Id { get; set; }

        public int? WinnerId { get; set; }


        public SessionDTO(int? id, int player1Id, int player2Id, int? winnerId)
        {
            ID = id;
            Player1Id = player1Id;
            Player2Id = player2Id;
            WinnerId = winnerId;
        }
    }
}
