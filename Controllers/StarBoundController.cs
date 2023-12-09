using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarBound.Data;
using StarBound.Models;
using StarBound.Models.Dto;

namespace StarBound.Controllers
{
    [Route("api/StarBound")]
    [ApiController]
    public class StarBoundController : ControllerBase
    {
        [HttpGet]
        public ActionResult <IEnumerable<StarShipDto>> GetStarShips()
        {
            return Ok(StarShipStore.starShipList);
        }

        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(StarShipDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetStarShip(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var starship = StarShipStore.starShipList.FirstOrDefault(s => s.Id == id);

            if(starship == null)
            {
                return NotFound();
            }
            return Ok(starship);
        }
    }
}
