using Microsoft.AspNetCore.Mvc;
using NavalWar.Business;
using NavalWar.DAL.Interfaces;
using NavalWar.DTO;

namespace NavalWar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _playerService;
        private readonly UserService _userService;
        private readonly SessionService _sessionService;
        public PlayerController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        // GET: api/<PlayerController>
        [HttpGet]
        public IActionResult GetPlayers()
        {
            return Ok(_playerService.GetPlayers());
        }

        // POST: api/<PlayerController>/{user}/{session}/ship	
        [HttpPost("{username}/{idSession}/fire")]
        public IActionResult Post([FromRouteAttribute] string username, int idsession, [FromBody] int x, [FromBody] int y)
        {
            UserDTO currentUser = _userService.GetUserByUsername(username);
            SessionDTO currentSession = _sessionService.GetSession(idsession);
            PlayerDTO currentPlayer = _playerService.GetPlayerByKeys(currentUser, currentSession);

            bool result = _playerService.ShotPlayer(currentPlayer, x, y);

            return Ok(result);
        }

        // PUT: api/<PlayerController>/{user}/{session}/ship	
        [HttpPut("{username}/{idSession}/ship")]
        public IActionResult Put(string username, int idsession, [FromBody] int x, [FromBody] int y)
        {
            UserDTO currentUser = _userService.GetUserByUsername(username);
            SessionDTO currentSession = _sessionService.GetSession(idsession);
            PlayerDTO currentPlayer = _playerService.GetPlayerByKeys(currentUser, currentSession);

            bool result = _playerService.ShotPlayer(currentPlayer, x, y);

            return Ok(result);
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
