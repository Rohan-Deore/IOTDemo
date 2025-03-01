namespace IOTBackEnd.Controllers.Manager
{
    public interface IManager
    {
        public IEnumerable<DeviceStatus> GetDeviceStatus();
    }
}
