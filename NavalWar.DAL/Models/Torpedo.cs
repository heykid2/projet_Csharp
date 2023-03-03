namespace NavalWar.DAL.Models
{
    internal class Torpedo : Ship
    {
        public Torpedo()
        {
            PV = 2;
        }
        public Torpedo(int? id, int x, int y, int size, bool isvertical) : base(id, 2, x, y, size, isvertical)
        {

        }

    }
}
