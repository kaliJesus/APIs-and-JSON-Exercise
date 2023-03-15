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
            var quote = new RonVSKanyeAPI(client);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"kanye: {quote.Kanye()}");
                Console.WriteLine($"Ron Swanson once said: {quote.Ron()}");
            }

            
        }
    }
}
