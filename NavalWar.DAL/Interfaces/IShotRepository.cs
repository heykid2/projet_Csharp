using NavalWar.DAL.Models;

namespace NavalWar.DAL.Interfaces
{
    public interface IShotRepository
    {
        public Shot? GetShotById(int shotId);
        public void InsertShot(Shot shot);
        public void Save();
    }
}
