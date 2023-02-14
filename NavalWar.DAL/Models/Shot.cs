using System.ComponentModel.DataAnnotations;

namespace NavalWar.DAL.Models
{
    public class Shot
    {
        [Key]
        public int? Id { get; set; }

        public int X { get; set; }
        
        public int Y { get; set; }
        
        public bool IsHit { get; set; }

        public Shot(int? id, int x, int y, bool isHit)
        {
            Id = id;
            X = x;
            Y = y;
            IsHit = isHit;
        }

    }
}
