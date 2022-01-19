using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpGetAndPostPractice.Service
{
    class HttpGetService
    {
        public static async Task GetMethod()
        {
            using (var client = new HttpClient())
            {
                Console.WriteLine(
                    "\n" +
                    "===========================================================" +
                    "\n" +
                    "       GET" +
                    "\n" +
                    "===========================================================" +
                    "\n"
                    );
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");

                var result = await client.GetStringAsync(endpoint);

                Console.WriteLine(result);
            }
        }
    }
}
