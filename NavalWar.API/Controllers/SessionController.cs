using Microsoft.AspNetCore.Mvc;
using NavalWar.Business;
using NavalWar.DAL;
using NavalWar.DTO;
using NavalWar.Utils;
using NavalWar.DAL.Interfaces;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NavalWar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ISessionService _sessionService;

        public SessionController(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        
        // GET: api/<GameAreaController>
        [HttpGet]
        [EnableCors("Policy")]
        public IActionResult GetSessions()
        {
            return Ok(_sessionService.GetSessions());
        }


        // GET api/<GameAreaController>/5
        [HttpGet("{id}")]
        [EnableCors("Policy")]
        public IActionResult GetSession(int id)
        {
            return Ok(_sessionService.GetSessionById(id));
        }

        //GET api/<SessionController>/5/status
        [HttpGet("{id}/status")]
        [EnableCors("Policy")]
        public IActionResult GetSessionStatus(int id)
        {
            return Ok(_sessionService.GetSessionStatus(id));
        }

        [HttpGet("sessions/{userId}/sessions/{sessionId}")]
        [EnableCors("Policy")]
        public IActionResult GetUserSession(int userId, int sessionId)
        {
            return Ok(_sessionService.GetUserSession(userId, sessionId));
        }

        // POST api/<GameAreaController>
        [HttpPost]
        [EnableCors("Policy")]
        public void PostSession([FromBody] SessionDTO session)
        {
            _sessionService.AddSession(session);
        }

        // PUT api/<GameAreaController>/5
        [HttpPut]
        [EnableCors("Policy")]
        public void Put([FromBody] SessionDTO session)
        {
            _sessionService.UpdateSession(session);
        }

        // DELETE api/<GameAreaController>/5
        [HttpDelete("sessions/{session}")]
        [EnableCors("Policy")]
        public void Delete(int session)
        {
            _sessionService.DeleteSession(session);
        }
    }
}