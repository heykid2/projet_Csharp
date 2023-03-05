namespace NavalWar.DAL.Models
{
    public class Cruiser : Ship
    {
        public Cruiser()
        {
            PV = 4;
        }

        public Cruiser(int? id, int x, int y, int size, bool isvertical) : base(id, 4, x, y, size, isvertical)
        {
            
        }
    }
}
