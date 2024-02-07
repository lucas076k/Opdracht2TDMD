using Domain.Data;
using System.Net.Http;
using System;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            // Replace "your-api-url" with the actual API endpoint
            var apiUrl = "http://localhost:80/api/newdeveloper";

            // Create an instance of the HueClient
            var hueClient = new HueClient(apiUrl);

            // Fetch and display lights
            var lights = await hueClient.GetLightsAsync();
            Console.WriteLine("Lights:");
            foreach (var light in lights)
            {
                Console.WriteLine($"Light ID: {light.Key}, Name: {light.Value.Name}");
            }

            // Fetch and display light state for a specific light
            var lightId = "4"; // Replace with the actual light ID
            var lightState = await hueClient.GetLightStateAsync(lightId);
            Console.WriteLine($"hoezo bitchass {lightState.ToString}");
            Console.WriteLine($"\nLight State - On: {lightState.On}, Bri: {lightState.Bri}, Hue: {lightState.Hue}, Sat: {lightState.Sat}");
        }
    }
}