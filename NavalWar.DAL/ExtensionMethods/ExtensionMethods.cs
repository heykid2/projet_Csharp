using NavalWar.DAL.Models;
using NavalWar.DTO;

namespace NavalWar.DAL.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static UserDTO ToDTO(this User user)
        {
            return new UserDTO(user.Name);
        }

        public static User ToModel(this UserDTO user)
        {
            return new User(user.UserName);
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
            return new PlayerDTO(player.User.ToDTO(), player.Session.ToDTO());
        }

        public static Player ToModel(this PlayerDTO player)
        {
            //return new Player(player.IDUser, player.IDSession);
            return new Player();
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
            return new ShipDTO(ship.ShipId, ship.PV, ship.X, ship.Y, ship.Size, ship.IsVertical, ship.Name);
        }
        
        public static Ship ToModel(this ShipDTO ship)
        {
            return new Ship(ship.ShipId, ship.PV, ship.X, ship.Y, ship.Size, ship.IsVertical, ship.Name);
        }

        // faire les autres
    }
}
