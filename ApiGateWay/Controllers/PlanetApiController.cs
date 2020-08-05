using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiGateWay.Controllers
{

    [ApiController]
    [Route("api/planets")]
    public class PlanetApiController : ControllerBase
    {

        [HttpGet]

        public async Task<ActionResult> GetPlanetsAsync()
        {
            try
            {
                var apiClient = HttpClientFactory.Create();

                var url = "http://localhost:5011/api/planets";
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

        [HttpPatch]

        public async Task<ActionResult> UpdatePlanetsAsync()
        {
            try
            {
                var apiClient = HttpClientFactory.Create();

                var url = "http://localhost:5011/api/planets";
                var body = "";
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    body=  await reader.ReadToEndAsync();
                }


                HttpContent content = new StringContent(
                    body,
                    Encoding.UTF8,
                    "application/json"
                );

                var result = await apiClient.PatchAsync(url, content);

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
