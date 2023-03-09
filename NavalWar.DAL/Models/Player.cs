using Microsoft.EntityFrameworkCore;

namespace NavalWar.DAL.Models
{
    //[PrimaryKey(nameof(User), nameof(Session))]
    public class Player
    {
        public int PlayerId { get; set; }
        
        public User User { get; set; }

        public Session Session { get; set; }

        public List<Ship> Ships { get; set; }

        public List<Shot> Shots { get; set; }

        public bool IsReady { get; set; }

        public Player()
        {
        }

        public Player(int playerId, User user, Session session, List<Ship> ships, List<Shot> shots, bool isReady)
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