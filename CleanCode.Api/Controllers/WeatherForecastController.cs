using System.Diagnostics;

using CleanCode.Models;

using Microsoft.AspNetCore.Mvc;

namespace CleanCode.Api.Controllers;

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

  public WeatherForecastController(ILogger<WeatherForecastController> logger) => _logger = logger;

  [HttpGet(Name = "GetWeatherForecast")]
  public IEnumerable<WeatherForecast> Get()
  {
    var rnd = new Random();
    var i = rnd.Next(0, 1);

// var i = 0;
    if (i == 1)
    {
      _logger.LogInformation("Nothing");

      return Enumerable.Empty<WeatherForecast>();
    }

    var retVal = Enumerable.Range(1, 5).Select(
      index => new WeatherForecast
               {
                 Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                 TemperatureC = Random.Shared.Next(-20, 55),
                 Summary = Summaries[Random.Shared.Next(Summaries.Length)]
               }).ToArray();

    Debug.WriteLine(retVal[0].TemperatureF);

    return retVal;
  }

  [HttpGet(Name = "GetTest")]
  public int GetTest(TestRequest request) => request.Id;
}
