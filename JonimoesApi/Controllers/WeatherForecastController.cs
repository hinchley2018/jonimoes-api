using Microsoft.AspNetCore.Mvc;

namespace JonimoesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private string[] Summaries;

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        Summaries = new[]{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Summaries.Select(item => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(0),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = item
        })
        .ToArray();
    }

    [HttpPost("")]
    public IActionResult CreateWeatherSummary([FromBody] string summary)
    {
        Summaries.Append(summary);
        return Ok($"{summary} created");
    }
}
