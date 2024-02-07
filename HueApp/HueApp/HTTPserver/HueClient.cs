using Newtonsoft.Json;
using System;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.Data;
using static System.Net.WebRequestMethods;
using System.Net.Http.Headers;

namespace HueApp.HTTPserver;

public class HueClient
{
    private HttpClient _httpClient;

    public HueClient(string apiUrl)
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(apiUrl);
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<Dictionary<string, Light>> GetLightsAsync()
    {
        var response = await _httpClient.GetAsync("newdeveloper/lights");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var lights = JsonConvert.DeserializeObject<Dictionary<string, Light>>(content);
        return lights;
    }

    public async Task<LightState> GetLightStateAsync(string lightId)
    {
        var response = await _httpClient.GetAsync($"newdeveloper/lights/{lightId}/state");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var lightState = JsonConvert.DeserializeObject<LightState>(content);
        return lightState;
    }
}
