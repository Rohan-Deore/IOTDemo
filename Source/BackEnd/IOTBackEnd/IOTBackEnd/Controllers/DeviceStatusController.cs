using IOTBackEnd.Controllers.Manager;
using Microsoft.AspNetCore.Mvc;

namespace IOTBackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class DeviceStatusController : ControllerBase
{
    private readonly ILogger<DeviceStatusController> _logger;

    public DeviceStatusController(ILogger<DeviceStatusController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetDeviceStatus")]
    public IEnumerable<DeviceStatus> Get()
    {
        _logger.LogInformation("Getting device status");

        IManager? manager = null;
        var isDevelopment = string.Equals(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"),
            "Development", StringComparison.InvariantCultureIgnoreCase);
        if (isDevelopment)
        {
            _logger.LogInformation("Data mocking being used");
            manager = new DataMockManager();
        }
        else
        {
            _logger.LogInformation("File manager being used");
            manager = new FileManager(); 
        }

        return manager.GetDeviceStatus();
    }
}
