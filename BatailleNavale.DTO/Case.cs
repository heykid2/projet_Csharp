
namespace BatailleNavale.DTO
{
    public class Case
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool EstTouche { get; set; }
        public bool EstOccupee { get; set; }
        public Navire? Navire { get; set; }
    }
}
