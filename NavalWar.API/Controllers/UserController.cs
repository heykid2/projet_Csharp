using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NavalWar.DAL.Interfaces;
using NavalWar.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NavalWar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        [EnableCors("Policy")]
        public IActionResult Get()
        {
            return Ok(_userService.GetUsers());
        }

        // GET api/<UserController>/wololo
        [HttpGet("{username}")]
        [EnableCors("Policy")]
        public IActionResult Get(string username)
        {
            return Ok(_userService.GetUserByUsername(username));
        }

        // POST api/<UserController>
        [HttpPost]
        [EnableCors("Policy")]
        public IActionResult Post([FromBody] UserDTO userDTO)
        {
            return (_userService.AddUser(userDTO)) ? Ok("Le User a bien été créé.") : BadRequest("Le User existe déjà.");
        }
    }
}
