using NavalWar.DAL.Models;

namespace NavalWar.DAL.Interfaces
{
    public interface IShipRepository
    {
        void InsertShip(Ship ship);
        void UpdateShip(Ship ship);
        void DeleteShip(int id);
        Ship GetShipById(int id);
        IEnumerable<Ship> GetShips();
    }
}
