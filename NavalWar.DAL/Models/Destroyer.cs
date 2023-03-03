namespace NavalWar.DAL.Models
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            PV = 3;
        }
        public Destroyer(int? id, int x, int y, int size, bool isvertical) : base(id, 3, x, y, size, isvertical)
        {

        }
    }
}
