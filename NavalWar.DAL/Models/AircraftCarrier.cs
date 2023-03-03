namespace NavalWar.DAL.Models
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier()
        {
            PV = 5;
        }
        
        public AircraftCarrier(int? id, int x, int y, int size, bool isvertical) : base(id, 5, x, y, size, isvertical)
        {
            
        }
    }
}
