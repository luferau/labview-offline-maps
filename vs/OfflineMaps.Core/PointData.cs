namespace OfflineMaps.Core
{
    public class PointData
    {
        public bool Warning { get; set; }
        public string Caption { get; set; }
        public double Latitude_deg { get; set; }
        public double Longitude_deg { get; set; }
        public double Altitude_m { get; set; }
        public double Speed_m_s { get; set; }
        public double Temperature_C { get; set; }

        public PointData()
        {

        }

        public PointData(
            bool warning,
            string caption,
            double latitude_deg, 
            double longitude_deg, 
            double altitude_m, 
            double speed_m_s, 
            double temperatureC)
        {
            this.Warning = warning;
            this.Caption = caption;
            this.Latitude_deg = latitude_deg;
            this.Longitude_deg = longitude_deg;
            this.Altitude_m = altitude_m;
            this.Speed_m_s = speed_m_s;
            this.Temperature_C = temperatureC;
        }
    }
}
