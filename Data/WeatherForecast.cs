using System;

namespace StoredProcedureTest.Data
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        
        public DateTime Weather_Date { get; set; }

        public int Temperature { get; set; }

        public int TemperatureF => 32 + (int)(Temperature / 0.5556);

        public string Summary { get; set; }
    }
}