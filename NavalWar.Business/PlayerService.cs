using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;
using NavalWar.DTO;
using NavalWar.DAL.ExtensionMethods;

namespace NavalWar.Business
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IShotRepository _shotRepository;
        private readonly ISessionRepository _sessionRepository;
        private readonly IShipRepository _shipRepository;

        public PlayerService(IPlayerRepository playerRepository, IShotRepository shotRepository, ISessionRepository sessionRepository, IShipRepository shipRepository)
        {
            _playerRepository = playerRepository;
            _shotRepository = shotRepository;
            _sessionRepository = sessionRepository;
            _shipRepository = shipRepository;
        }

        public List<PlayerDTO> GetPlayers()
        {
            List<Player> players = (List<Player>)_playerRepository.GetPlayers();
            return players.Select(p => p.ToDTO()).ToList();
        }

        public void AddPlayer(PlayerDTO player)
        {
            _playerRepository.InsertPlayer(player.ToModel());
        }
        //TODO :
        public PlayerDTO GetPlayerByKeys(UserDTO UserDTP, SessionDTO SessionDTP)
        {
            return null;
        }
        
        
        //TODO : MAJ BATEAU EN BD
        public int Fire(int playerId, ShotDTO shot)
        {
            int result; // -1 = erreur, 0 = loupé, 1 = touché, 2 = coulé, 3 = coulé et gagné
            Player player;
            Session session;
            Player adversaire;
            Ship? hitShip = null;

            if (shot.X < 0 || shot.X >= 10 || shot.Y < 0 || shot.Y >= 10)
            {
                result = -1;
            }
            else
            {
                player = _playerRepository.GetPlayerById(playerId);
                session = player.Session;
                adversaire = session.Player1Id == playerId ? _playerRepository.GetPlayerById(session.Player2Id) : _playerRepository.GetPlayerById(session.Player1Id);
                foreach (Ship ship in adversaire.Ships)
                {
                    int ship_begin_x = ship.X;
                    int ship_begin_y = ship.Y;
                    
                    if (ship.IsVertical)
                    {
                        if (shot.X == ship_begin_x && shot.Y >= ship_begin_y && shot.Y < ship_begin_y + ship.Size)
                        {
                            hitShip = ship;
                            break;
                        }
                    }
                    else
                    {
                        if (ship.Y == ship_begin_y && shot.X >= ship_begin_x && shot.X < ship_begin_x + ship.Size)
                        {
                            hitShip = ship;
                            break;
                        }
                    }
                }
                
                if (hitShip == null)
                {
                    result = 0;
                }
                else
                {
                    shot.Hit = true;
                    _shotRepository.InsertShot(shot.ToModel());
                    player.Shots.Add(shot.ToModel());
                    _playerRepository.UpdatePlayer(player);
                    hitShip.PV--;
                    if (hitShip.PV == 0)
                    {
                        result = 2;
                        bool isWon = true;
                        foreach (Ship ship in adversaire.Ships)
                        {
                            if (ship.PV == 0)
                            {
                                isWon = false;
                                break;
                            }
                        }
                        if (isWon)
                        {
                            result = 3;
                        }
                    }
                    else
                    {
                        result = 1;
                    }
                    _shipRepository.UpdateShip(hitShip);
                }
            }

            return result;
        }

        public int UpdateShip(int playerId, int shipId, ShipDTO shipDto)
        {
            int result = -1; // -1 = erreur, 0 = ok
            Player player = _playerRepository.GetPlayerById(playerId);
            Ship? ship = player.Ships.Where(s => s.ShipId == shipId).FirstOrDefault();
            if (ship != null)
            {
                ship.X = shipDto.X;
                ship.Y = shipDto.Y;
                ship.IsVertical = shipDto.IsVertical;
                _shipRepository.UpdateShip(ship);
                result = 0;
            }
            return result;
        }

    }
}
