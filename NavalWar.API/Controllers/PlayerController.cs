using Microsoft.AspNetCore.Mvc;
using NavalWar.Business;

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
            return Ok(_playerService.GetPlayers());
        }

    }
}
