namespace IOTBackEnd.Controllers.Manager
{
    public class DatabaseManager : IManager
    {
        public DatabaseManager() { }

        public IEnumerable<DeviceStatus> GetDeviceStatus()
        {
            return new List<DeviceStatus>();
        }
    }
}
