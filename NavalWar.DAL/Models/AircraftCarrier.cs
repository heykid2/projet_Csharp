using Microsoft.EntityFrameworkCore.ChangeTracking;
using NavalWar.DAL.Interfaces;
using System.Numerics;

namespace NavalWar.DAL.Models
{
    public class AircraftCarrier : IShip
    {
        private int _pv = 5;

        public int GetPV()
        {
            return _pv;
        }
    }
}
