using Domain.Data;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sex = HueClient.GetLightStateFromApi();
            Console.WriteLine(sex);
        }
    }
}