using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Request_and_Responses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getHeader")]
        public IActionResult GetHeader()
        {
            var headers = base.Request.Headers;
            Console.WriteLine(headers);
            return base.Ok(headers);
        }

        [HttpGet("getQuery")]
        public IActionResult GetQuery()
        {
            var query = base.Request.QueryString;
            Console.WriteLine(query);
            return base.Ok(query);
        }
    }
}
