using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApp
{
    public class WeatherData
    {
        public required string City { get; set; }
        public required string MainCondition { get; set; }
        public required string Description { get; set; }
        public double Temperature { get; set; }
        public double FeelsLike { get; set; }

        public int Humidity { get; set; }

        public double WindSpeed { get; set; }

    }
}
