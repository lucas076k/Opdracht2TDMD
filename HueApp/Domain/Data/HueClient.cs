using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Domain.Data
{
    public class HueClient
    {
        public static async Task<LightState> GetLightStateFromApi()
        {
            string apiUrl = "http://localhost/api/newdeveloper";
            using (HttpClient httpClient = new HttpClient())
            {

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        return json;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                return null;
            }
        }
    }
}
