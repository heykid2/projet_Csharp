using Microsoft.AspNetCore.Mvc;
using NavalWar.Business;
using NavalWar.DAL;
using NavalWar.DTO;
using NavalWar.Utils;
using NavalWar.DAL.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NavalWar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        //private readonly ISessionService _sessionService;

        //public SessionController(ISessionService sessionService)
        //{
        //    _sessionService = sessionService;
        //}

        
        //// GET: api/<GameAreaController>
        //[HttpGet]
        //public IActionResult GetSessions()
        //{
        //    List<SessionDTO> sessions = _sessionService.GetSessions();

        //    return Ok(sessions);
        //}
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
