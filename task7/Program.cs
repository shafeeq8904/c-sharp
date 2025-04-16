using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            using HttpClient client = new HttpClient();

            Task<string> jokeTask = FetchJokeAsync(client);
            Task<string> catFactTask = FetchCatFactAsync(client);

            string[] results = Task.WhenAll(jokeTask, catFactTask).Result;

            Console.WriteLine("Joke (Raw JSON): " + results[0]);
            Console.WriteLine("Cat Fact (Raw JSON): " + results[1]);
        }

        static async Task<string> FetchJokeAsync(HttpClient client)
        {
            string jokeApi = "https://v2.jokeapi.dev/joke/Any?type=single";
            return await client.GetStringAsync(jokeApi);
        }

        static async Task<string> FetchCatFactAsync(HttpClient client)
        {
            string catApi = "https://catfact.ninja/fact";
            return await client.GetStringAsync(catApi);
        }
    }
}
