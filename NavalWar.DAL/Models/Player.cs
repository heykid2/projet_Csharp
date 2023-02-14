using Microsoft.EntityFrameworkCore;

namespace NavalWar.DAL.Models
{
    [PrimaryKey(nameof(UserId), nameof(SessionId))]
    public class Player
    {
        public int UserId { get; set; }

        public int SessionId { get; set; }

        public List<Ship> Ships { get; set; }

        public List<Shot> Shots { get; set; }

        public User User { get; set; }
    }
}