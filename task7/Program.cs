using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();

            // Fetch joke and cat fact
            string joke = await FetchJokeAsync(client);
            string catFact = await FetchCatFactAsync(client);

            Console.WriteLine(" Joke: " + joke);
            Console.WriteLine(" ------------------------------------------------------------------------");
            Console.WriteLine(" Cat Fact: " + catFact);
        }

        static async Task<string> FetchJokeAsync(HttpClient client)
        {
            string jokeApi = "https://v2.jokeapi.dev/joke/Any?type=single";
            string response = await client.GetStringAsync(jokeApi);

            using JsonDocument doc = JsonDocument.Parse(response);
            JsonElement root = doc.RootElement;

            if (root.TryGetProperty("joke", out JsonElement jokeElement))
            {
                return jokeElement.GetString(); // Just the joke string
            }

            return "No joke found.";
        }

        static async Task<string> FetchCatFactAsync(HttpClient client)
        {
            string catApi = "https://catfact.ninja/fact";
            string response = await client.GetStringAsync(catApi);

            using JsonDocument doc = JsonDocument.Parse(response);
            JsonElement root = doc.RootElement;

            if (root.TryGetProperty("fact", out JsonElement factElement))
            {
                return factElement.GetString(); // Just the fact string
            }

            return "No cat fact found.";
        }
    }
}
