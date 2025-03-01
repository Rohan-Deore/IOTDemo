namespace IOTBackEnd
{
    public class DeviceStatus
    {
        public string DeviceName { get; set; } = string.Empty;

        public string DeviceVersion { get; set; } = string.Empty;

        public bool Status { get; set; }

        public DateTime StatusTime { get; set; }

    }
}
