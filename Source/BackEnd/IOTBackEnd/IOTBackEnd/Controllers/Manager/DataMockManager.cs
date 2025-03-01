namespace IOTBackEnd.Controllers.Manager
{
    public class DataMockManager : IManager
    {
        public IEnumerable<DeviceStatus> GetDeviceStatus()
        {
            return GetDeviceStatus();
        }

        public List<DeviceStatus> CreateData(string name)
        {
            DateTime statusTime = new DateTime(2025, 3, 1, 8, 0, 0);
            TimeSpan delta = TimeSpan.FromMinutes(1);
            List<DeviceStatus> statuses = new List<DeviceStatus>();

            DateTime limit = new DateTime(2025, 3, 1, 18, 0, 0);
            bool currentStatus = true;

            Random random = new Random();

            while (statusTime < limit)
            {
                int sameStatus = random.Next(7, 20);
                for (int x = 0; x < sameStatus; x++)
                {
                    statusTime = statusTime.Add(delta);
                    statuses.Add(new DeviceStatus() 
                    { 
                        DeviceName = "Raspberry pi", 
                        Status = currentStatus, 
                        StatusTime = statusTime, 
                        DeviceVersion = "1.0" 
                    });
                }

                currentStatus = !currentStatus;
            }

            return statuses;
        }
    }
}
