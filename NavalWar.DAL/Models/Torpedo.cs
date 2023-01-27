using NavalWar.DAL.Interfaces;

namespace NavalWar.DAL.Models
{
    internal class Torpedo : IShip
    {
        private int _pv = 2;

        public int GetPV()
        {
            return _pv;
        }
    }
}
