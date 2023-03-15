using System;
using System.Net.Http;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;




namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)

        {
            var client = new HttpClient();
            var apiKey = "186bf91a1f1a358bb0e0b54dc8412f06";
            Console.WriteLine("Enter city: ");
            var cityName = Console.ReadLine();
            var mapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";
            string response = client.GetStringAsync(mapURL).Result;
            var Temp = JObject.Parse(response);
            Console.WriteLine($"It is currently {Temp["main"]["temp"]} degree F in {cityName}");

            

        }
}
}
