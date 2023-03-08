using Microsoft.AspNetCore.Mvc;
using NavalWar.Business;
using NavalWar.DAL.Interfaces;
using NavalWar.DAL.Models;
using NavalWar.DTO;

namespace NavalWar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        // GET: api/<PlayerController>
        [HttpGet]
        public IActionResult GetPlayers()
        {
            return Ok(new List<Player>());
        }
        

        // POST: api/<PlayerController>/5/fire	
        [HttpPost("{playerId}/fire")]
        public IActionResult Post([FromRoute] int playerId, [FromBody] ShotDTO shot)
        {
            int result = _playerService.Fire(playerId, shot); 

            // -1 = erreur, 0 = loupé, 1 = touché, 2 = coulé, 3 = coulé et gagné
            return Ok(result);
        }

        [HttpPost]
        public void CreatePlayer([FromBody] PlayerDTO player)
        {
            player.Ships = new List<ShipDTO>
            {
                new ShipDTO(1, 5, -1, -1, 5, true, "Aircraft Carrier"),
                new ShipDTO(2, 4, -1, -1, 4, true, "Battleship"),
                new ShipDTO(3, 3, -1, -1, 3, true, "Destroyer"),
                new ShipDTO(4, 3, -1, -1, 3, true, "Submarine"),
                new ShipDTO(5, 2, -1, -1, 2, true, "Patrol Boat")
            };

            _playerService.AddPlayer(player);
        }

        // PUT: api/<PlayerController>/{user}/{session}/ship	
        [HttpPut("{playerId}/ship/{shipId}")]
        public IActionResult Put([FromRoute] int playerId, [FromRoute] int shipId,
                                    [FromBody] ShipDTO ship)
        {
            return Ok(_playerService.UpdateShip(playerId, shipId, ship));
        }

        [HttpGet("/{playerId}/ships")]
        public IActionResult GetPlayerShips(int playerId)
        {
            return Ok(_playerService.GetShips(playerId));
        }



        /*
// GET api/<GameAreaController>/5
[HttpGet("{id}")]
public string Get(int id)
{
    return "value";
}

// POST api/<GameAreaController>
[HttpPost]
public void Post([FromBody] string value)
{
}

// PUT api/<GameAreaController>/5
[HttpPut("{id}")]
public void Put(int id, [FromBody] string value)
{
}

// DELETE api/<GameAreaController>/5
[HttpDelete("{id}")]
public void Delete(int id)
{
}
*/

    }
}
