using Microsoft.AspNetCore.Mvc;
using BatailleNavale.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BatailleNavale.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamingMapController : ControllerBase
    {
        // GET: api/<GamingMapController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new Partie());
        }

        // GET api/<GamingMapController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GamingMapController>
        [HttpPost("{idPartie}/navire")]
        public IActionResult Post(int idPartie, [FromBody] string value)
        {
            Partie partie = new Partie();
            partie.Joueur1.MapDefense.AjouterNavire(new PorteAvion(), 2, 2, Direction.Droite);
            return Ok(partie.Joueur1.MapDefense);
        }

        // PUT api/<GamingMapController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GamingMapController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
