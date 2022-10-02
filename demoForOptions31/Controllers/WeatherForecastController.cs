using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoForOptions31.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demoForOptions31.Controllers
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

        [HttpGet]
        public int Get([FromServices]IOrderService orderService)
        {
            Console.WriteLine($"Max Order Count:{orderService.ShowMaxOrderCount()}");
            return 1;
        }
    }
}
