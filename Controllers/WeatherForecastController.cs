using Microsoft.AspNetCore.Mvc;

namespace NannoA_MiniChallengeTwoToFour_Endpoints.Controllers;

[ApiController]// telling dotnet to read this file as an api controlooer
[Route("[controller]")]//removing the need to type controller to access this file 
public class WeatherForecastController : ControllerBase
// : ControllerBase allows us to access all of the built in dotnet methods 
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)//constructor 
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]// this let us and c# know what the next method is going to do with the data
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
