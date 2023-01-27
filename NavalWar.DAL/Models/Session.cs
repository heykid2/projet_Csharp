using NavalWar.DTO;

namespace NavalWar.DAL.Models
{
    public class Session
    {
        public int ID { get; set; }

        List<Player> _players = new List<Player>();

        public SessionDTO ToDto()
        {
            return new SessionDTO();
        }

        public List<Player> Players
        {
            get { return _players; }
        }

        public bool isGameFull()
        {
            return _players.Count == 2;
        }

        public void AddPLayer()
        {
            if (isGameFull())
            {
                throw new Exception("Game is full (Max 2 players)");
            }
            _players.Add(new Player());
        }
    }
}
