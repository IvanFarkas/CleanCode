namespace CleanCode.Api.Controllers
{
  using Microsoft.AspNetCore.Mvc;

  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private static readonly string[] Summaries =
      {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
      };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger) => this._logger = logger;

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
      var rnd = new Random();
      var i = rnd.Next(0, 1);
      //    var i = 0;

      #region Region Description
      if (i == 1)
      {
        this._logger.LogInformation("Nothin");

        return Enumerable.Empty<WeatherForecast>();
      }
      #endregion

      return Enumerable.Range(1, 5).Select(
        index => new WeatherForecast
                   {
                     Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                     TemperatureC = Random.Shared.Next(-20, 55),
                     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                   }).ToArray();
    }
  }
}
