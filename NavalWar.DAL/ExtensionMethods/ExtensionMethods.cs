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
            return new User(user.Name);
        }
        public static SessionDTO ToDTO(this Session session)
        {
            return new SessionDTO(session.ID, session.Player1.ToDTO(), session.Player2.ToDTO());
        }

        public static Session ToModel(this SessionDTO session)
        {
            return new Session(session.ID, session.Player1.ToModel(), session.Player2.ToModel());
        }

        public static PlayerDTO ToDTO(this Player player)
        {
            return new PlayerDTO(player.UserId, player.SessionId);
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

        public static AircraftCarrierDTO ToDTO(this AircraftCarrier aircraftCarrier)
        {
            return new AircraftCarrierDTO(aircraftCarrier.ID, aircraftCarrier.PV);
        }
        
        public static AircraftCarrier ToModel(this AircraftCarrierDTO aircraftCarrier)
        {
            return new AircraftCarrier(aircraftCarrier.ID, aircraftCarrier.PV);
        }

        // faire les autres
    }
}
