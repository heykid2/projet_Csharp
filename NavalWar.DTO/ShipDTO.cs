namespace NavalWar.DTO
{
    public class ShipDTO
    {
        public int? ID { get; set; }
        public int PV { get; set; }
        
            

        public ShipDTO(int? id, int pv)
        {
            ID = id;
            PV = pv;
        }
    }
}
