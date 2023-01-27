using NavalWar.DAL.Interfaces;

namespace NavalWar.DAL.Models
{
    internal class Cruiser : IShip
    {
        private int _pv = 4;

        public int GetPV()
        {
            return _pv;
        }
    }
}
