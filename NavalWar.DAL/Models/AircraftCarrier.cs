﻿namespace NavalWar.DAL.Models
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier()
        {
            PV = 5;
        }
        
        public AircraftCarrier(int? id, int pv) : base(id, pv)
        {
            
        }
    }
}
