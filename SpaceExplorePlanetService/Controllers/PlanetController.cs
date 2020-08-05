using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpaceExplorePlanetService.DataLayer;
using SpaceExplorePlanetService.DataLayer.Entities;

namespace SpaceExplorePlanetService.Controllers
{
    [Route("api/planets")]
    [ApiController]
    public class PlanetController: ControllerBase
    {
        [HttpGet]

        public ActionResult GetPlanets()
        {
            try
            {
                
                using var _context = new PlanetServiceDBContext();
                var planets = _context.Planets.ToList();
                return Ok(planets);
            }
            catch (Exception ex)
            {
                //Some cool logging mechanism 
                Console.Write("Error at getting the planets: " + ex.Message);
                return StatusCode(500, "An error occurred");
            }
        }
        [HttpPatch]
        public ActionResult UpdatePlanet([FromBody] Planet planet)
        {
            try
            {
                using var _context = new PlanetServiceDBContext();
                var planetToUpdate = _context.Planets.FirstOrDefault(p => p.PlanetId == planet.PlanetId);
                if (planetToUpdate == null) return NotFound();

                planetToUpdate.Description = planet.Description;
                planetToUpdate.CrewId = planet.CrewId;
                planetToUpdate.PlanetStatus = planet.PlanetStatus;
                    
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                //Some cool logging mechanism 
                Console.Write("Error at updating the planet: " + ex.Message);
                return StatusCode(500, "An error occurred");
            }
        }




    }
}
