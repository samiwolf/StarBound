using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarBound.Models;

namespace StarBound.Controllers
{
    [Route("api/StarBound")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StarShip> GetStarShips()
        {
            return new List<StarShip> { 
                new StarShip {Id=1, Name="Explorer"},
                new StarShip {Id=2, Name="Rover"}  
            };
        }
    }
}
