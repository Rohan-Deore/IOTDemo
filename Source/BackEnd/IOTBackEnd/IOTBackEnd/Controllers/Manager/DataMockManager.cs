using NLog;

namespace IOTBackEnd.Controllers.Manager
{
    public class DataMockManager : IManager
    {
        private NLog.ILogger _logger;

        public DataMockManager()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public IEnumerable<DeviceStatus> GetDeviceStatus()
        {
            return CreateData();
        }

        public List<DeviceStatus> CreateData()
        {
            _logger.Info("Creating device status data");

            var timeNow = DateTime.Now;
            var dateOnly = DateOnly.FromDateTime(timeNow);
            var timeOnlyStart = new TimeOnly(8, 0);
            DateTime statusTime = new DateTime(dateOnly, timeOnlyStart);
            
            TimeSpan delta = TimeSpan.FromMinutes(5);
            List<DeviceStatus> statuses = new List<DeviceStatus>();

            var timeOnlyLimit = new TimeOnly(8, 30);
            DateTime limit = new DateTime(dateOnly, timeOnlyLimit);
            //DateTime limit = new DateTime(2025, 3, 1, 18, 0, 0);
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

            _logger.Info($"Device Status created for {statuses.Count}");
            return statuses;
        }
    }
}
