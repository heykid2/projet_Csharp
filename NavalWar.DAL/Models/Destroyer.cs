using NavalWar.DAL.Interfaces;

namespace NavalWar.DAL.Models
{
    internal class Destroyer : IShip
    {
        private int _pv = 3;

        public int GetPV()
        {
            return _pv;
        }
    }
}
