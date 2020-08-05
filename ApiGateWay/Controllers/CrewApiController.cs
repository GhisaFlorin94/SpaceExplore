using System;

using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace ApiGateWay.Controllers
{
    [ApiController]
    [Route("api/crews")]
    public class CrewApiController : ControllerBase
    {
        [HttpGet]

        public async Task<ActionResult> GetCrewsAsync()
        {
            try
            {
                var apiClient = HttpClientFactory.Create();

                var url = "http://localhost:5012/api/crews";
                var result = await apiClient.GetStringAsync(url);

                return Ok(result);
            }
            catch (Exception ex)
            {
                //Some cool logging mechanism 
                Console.Write("Error at getting the planets: " + ex.Message);
                return StatusCode(500, "An error occurred");
            }
        }

    }
}
