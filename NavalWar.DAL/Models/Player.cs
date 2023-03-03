using Microsoft.EntityFrameworkCore;

namespace NavalWar.DAL.Models
{
    //[PrimaryKey(nameof(User), nameof(Session))]
    public class Player
    {
        public int PlayerId { get; set; }
        
        public User User { get; set; }
        
        //public int UserId { get; set; }

        public Session Session { get; set; }

        public List<Ship> Ships { get; set; }

        public List<Shot> Shots { get; set; }


    }
}