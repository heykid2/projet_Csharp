using NavalWar.DAL.Models;
using NavalWar.DTO;

namespace NavalWar.DAL.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static UserDTO ToDTO(this User user)
        {
            return new UserDTO(user.Name, user.Id);
        }

        public static User ToModel(this UserDTO user)
        {
            return new User(user.Name, user.Id);
        }
        public static SessionDTO ToDTO(this Session session)
        {
            return new SessionDTO(session.SessionId, session.Player1Id, session.Player2Id, session.WinnerPlayerId, session.Status);
        }
        
        public static Session ToModel(this SessionDTO session)
        {
            return new Session(session.SessionId, session.Player1Id, session.Player2Id, session.WinnerPlayerId, session.Status);
        }
        
        public static PlayerDTO ToDTO(this Player player)
        {
            List<ShipDTO> ships = new List<ShipDTO>();
            List<ShotDTO> shots = new List<ShotDTO>();

            foreach (Ship ship in player.Ships)
            {
                ships.Add(ship.ToDTO());
            }

            foreach (Shot shot in player.Shots)
            {
                shots.Add(shot.ToDTO());
            }

            return new PlayerDTO(player.PlayerId, player.User.ToDTO(), player.Session.ToDTO(), ships, shots);
        }

        public static Player ToModel(this PlayerDTO player)
        {
            List<Ship> ships = new List<Ship>();
            List<Shot> shots = new List<Shot>();

            foreach (ShipDTO ship in player.Ships)
            {
                ships.Add(ship.ToModel());
            }

            foreach (ShotDTO shot in player.Shots)
            {
                shots.Add(shot.ToModel());
            }

            return new Player(player.Id, player.User.ToModel(), player.Session.ToModel(), ships, shots);
        }

        public static ShotDTO ToDTO(this Shot shot)
        {
            return new ShotDTO(shot.Id, shot.X, shot.Y, shot.IsHit);
        }

        public static Shot ToModel(this ShotDTO shot)
        {
            return new Shot(shot.ID, shot.X, shot.Y, shot.Hit);
        }

        public static ShipDTO ToDTO(this Ship ship)
        {
            return new ShipDTO(ship.ID, ship.PV, ship.X, ship.Y, ship.Size, ship.isVertical, ship.Name);
        }

        public static Ship ToModel(this ShipDTO ship)
        {
            return new Ship(ship.ID, ship.PV, ship.X, ship.Y, ship.Size, ship.isVertical, ship.Name);
        }

        // faire les autres
    }
}
