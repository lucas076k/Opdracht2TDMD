using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleHttp
{
    class Program
    {
        static async Task Main()
        {
            // Create an instance of HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                // Specify the URL you want to send the GET request to
                string apiUrl = "http://localhost/api/newdeveloper";

                // Send the GET request and get the response
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                // Check if the request was successful (status code 200-299)
                if (response.IsSuccessStatusCode)
                {
                    // Read and print the content of the response
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                }
                else
                {
                    // Print the status code if the request was not successful
                    Console.WriteLine($"Request failed with status code: {response.StatusCode}");
                }
            }
        }
    }

}