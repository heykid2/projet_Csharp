using Microsoft.AspNetCore.Mvc;
using NavalWar.Business;

namespace NavalWar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _playerService;

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

        // POST: api/<PlayerController>/


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
