namespace NavalWar.DAL.Models
{
    public class Ship
    {
        public int? ID { get; set; }
        public int PV { get; set; }
        
        public Ship()
        {
            
        }

        public Ship(int? id, int pv)
        {
            ID = id;
            PV = pv;
        }
        
    }

}
