using NavalWar.DAL.Models;
using NavalWar.DTO;

namespace NavalWar.DAL.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static UserDTO ToDTO(this User user)
        {
            List<PlayerDTO> players = new();

            foreach (Player player in user.Players)
            {
                players.Add(player.ToDTO());
            }

            return new UserDTO(user.Name, players);
        }

        public static User ToModel(this UserDTO user)
        {
            return new User(user.Name);
        }
        public static SessionDTO ToDTO(this Session session)
        {
            return new SessionDTO(session.SessionId, session.Player1Id, session.Player2Id, session.WinnerPlayerId, session.Status, session.CurrentPlayer);
        }
        
        public static Session ToModel(this SessionDTO session)
        {
            return new Session(session.SessionId, session.Player1Id, session.Player2Id, session.WinnerPlayerId, session.Status, session.CurrentPlayer);
        }
        
        public static PlayerDTO ToDTO(this Player player)
        {
            List<ShipDTO> shipsDTO = new();
            List<ShotDTO> shotsDTO = new();

            foreach (Ship ship in player.Ships)
            {
                shipsDTO.Add(ship.ToDTO());
            }

            foreach (Shot shot in player.Shots)
            {
                shotsDTO.Add(shot.ToDTO());
            }

            return new PlayerDTO(player.PlayerId, player.User.ToDTO(), player.Session.ToDTO(), shipsDTO, shotsDTO, player.IsReady);
        }

        public static Player ToModel(this PlayerDTO player)
        {
            List<Ship> ships = new();
            List<Shot> shots = new();

            foreach (ShipDTO ship in player.Ships)
            {
                ships.Add(ship.ToModel());
            }

            foreach (ShotDTO shot in player.Shots)
            {
                shots.Add(shot.ToModel());
            }

            return new Player(player.PlayerId, player.User.ToModel(), player.Session.ToModel(), ships, shots, player.IsReady);
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
