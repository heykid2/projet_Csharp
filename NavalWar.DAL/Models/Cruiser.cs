namespace NavalWar.DAL.Models
{
    public class Cruiser : Ship
    {
        public Cruiser()
        {
            PV = 4;
        }

        public Cruiser(int? id, int pv) : base(id, pv)
        {
            
        }
    }
}
