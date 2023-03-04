using Microsoft.AspNetCore.Mvc;

namespace CleanCode.Api.Controllers
{
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

    public WeatherForecastController(ILogger<WeatherForecastController> logger) { _logger = logger; }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
      var i = 0;

      if (i == 1)
      {
        return null;
      }

      return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                                                    {
                                                      Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                                                      TemperatureC = Random.Shared.Next(-20, 55),
                                                      Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                                                    })
        .ToArray();
    }

    private void Method1() { }

    #region Region Description
    private void Method2() { }
    #endregion

    private void Method3() { }
  }
}
