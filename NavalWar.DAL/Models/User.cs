using System.ComponentModel.DataAnnotations;

namespace NavalWar.DAL.Models
{
    public class User
    {
        [Key]
        public string? Name { get; set; }

        public List<Player> Players { get; set; }

        public User(string? name)
        {
            Name = name;
            Players = new();
        }
    }
}