using OpenWeatherApp;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.Write("Enter the name of your city: ");
        string? city = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(city))
        {
            Console.WriteLine("City name cannot be empty. Please try again.");
            return;
        }

        var service = new WeatherService();
        var weather = await service.GetWeatherAsync(city);

        WeatherDisplay.Show(weather);
    }
}