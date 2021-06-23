using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoredProcedureTest.Data;

namespace StoredProcedureTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeathersRepository _repository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeathersRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get() =>
            _repository.GetAll();

        [HttpPost]
        public int Post([FromBody] WeatherModel model) =>
            _repository.ChangeTemperature(model.Id, model.Temperature);
    }
}