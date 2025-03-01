namespace IOTBackEnd.Controllers.Manager
{
    public class DataMockManager : IManager
    {
        public IEnumerable<DeviceStatus> GetDeviceStatus()
        {
            return Enumerable.Range(1, 5).Select(index => new DeviceStatus
            {
                StatusTime = DateTime.Now.AddDays(index),
                Status = true,
                DeviceName = "Raspberry Pi",
                DeviceVersion = "1.0"
            })
            .ToArray();
        }
    }
}
