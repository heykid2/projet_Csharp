using System.ComponentModel.DataAnnotations;

namespace NavalWar.DAL.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Player>? Players { get; set; }

        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}