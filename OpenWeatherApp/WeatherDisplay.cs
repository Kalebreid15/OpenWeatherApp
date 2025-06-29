using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApp
{
    public class WeatherDisplay
    {
        public static void Show(WeatherData data)
        {
            Console.WriteLine($"\n--- Weather in {data.City} ---");
            Console.WriteLine($"Condition: {data.MainCondition}");
            Console.WriteLine($"Temperature: {data.Temperature}°F");
            Console.WriteLine($"Feels Like: {data.FeelsLike}°F");
            Console.WriteLine($"Humidity: {data.Humidity}%");
            Console.WriteLine($"Wind Speed: {data.WindSpeed} mph");
            Console.WriteLine();

            if (!string.IsNullOrEmpty(data.Description))
            {
                Console.WriteLine($"Description: {data.Description}");
            }
            else
            {
                Console.WriteLine("No additional description available.");
            }
        }
    }
}

