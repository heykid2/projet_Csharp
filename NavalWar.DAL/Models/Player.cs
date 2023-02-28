using Microsoft.EntityFrameworkCore;

namespace NavalWar.DAL.Models
{
    //[PrimaryKey(nameof(User), nameof(Session))]
    public class Player
    {
        public User isUser { get; set; }
        
        //public int UserId { get; set; }

        public Session ofSession { get; set; }

        public Map HasMap { get; set; }

        public List<Ship> Ships { get; set; }

        public List<Shot> Shots { get; set; }


    }
}