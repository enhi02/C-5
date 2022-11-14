using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using slide.Model;
using slide.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace slide.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        IRepository _repo;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepository repobeo)
        {
            _repo = repobeo;
            _logger = logger;
        }
        [HttpGet]
        public List<Reservation> GetList()
        {
            return _repo.GetList();
        }
    }
}
