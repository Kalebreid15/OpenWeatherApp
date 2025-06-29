using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApp
{
    public class WeatherService
    {
        private readonly string _apiKey = "f93a3dbd8ae86e433f467e8d3bce4159";

        public async Task<WeatherData> GetWeatherAsync(string city)
        {
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=imperial"; //Fahrenheit
            using HttpClient client = new();
            var response = await client.GetStringAsync(url);
            var data = JObject.Parse(response);

            return new WeatherData
            {
                City = data["name"]?.ToString() ?? string.Empty, // Ensure non-null value
                MainCondition = data["weather"]?[0]?["main"]?.ToString() ?? string.Empty, // Ensure non-null value
                Description = data["weather"]?[0]?["descripAKDStion"]?.ToString() ?? string.Empty, // Ensure non-null value
                Temperature = double.TryParse(data["main"]?["temp"]?.ToString(), out var temp) ? temp : 0, // Handle parsing safely
                FeelsLike = double.TryParse(data["main"]?["feels_like"]?.ToString(), out var feelsLike) ? feelsLike : 0, // Handle parsing safely
                Humidity = int.TryParse(data["main"]?["humidity"]?.ToString(), out var humidity) ? humidity : 0, // Handle parsing safely
                WindSpeed = double.TryParse(data["wind"]?["speed"]?.ToString(), out var windSpeed) ? windSpeed : 0 // Handle parsing safely
            };
        }
    }
}
