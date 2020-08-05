using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpaceExploreCrewService.DataLayer;

namespace SpaceExploreCrewService.Controllers
{


    [Route("api/crews")]
    [ApiController]
    public class CrewController: ControllerBase
    {

        [HttpGet]
        public ActionResult GetCrews()
        {
            try
            {

                using var _context = new CrewServiceDBContext();
                var crews = _context.Crews
                    .Include(c => c.Shuttle)
                    .Include(c => c.Captain)
                    .Include(c => c.Robots)
                    .ToList();
                return Ok(crews);
            }
            catch (Exception ex)
            {
                //Some cool logging mechanism 
                Console.Write("Error at getting the crews: " + ex.Message);
                return StatusCode(500, "An error occurred");
            }
        }
    }
}
