using Microsoft.AspNetCore.Mvc;

namespace IOTBackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class DeviceStatusController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<DeviceStatusController> _logger;

    public DeviceStatusController(ILogger<DeviceStatusController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetDeviceStatus")]
    public IEnumerable<DeviceStatus> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new DeviceStatus
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
