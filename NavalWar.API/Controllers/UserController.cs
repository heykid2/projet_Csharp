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
        public IActionResult Get()
        {
            return Ok(_userService.GetUsers());
        }

        // GET api/<UserController>/wololo
        [HttpGet("{username}")]
        public IActionResult Get(string username)
        {
            return Ok(_userService.GetUserByUsername(username));
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserDTO userDTO)
        {
            _userService.AddUser(userDTO);
        }
    }
}
