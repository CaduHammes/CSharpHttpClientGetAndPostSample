using HttpGetAndPostPractice.Entities;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace HttpGetAndPostPractice.Service
{
    class HttpPostService
    {
        public static void PostMethod()
        {
            using (var client = new HttpClient())
            {
                Console.WriteLine(
                    "\n" +
                    "===========================================================" +
                    "\n" +
                    "       POST"+
                    "\n" +
                    "===========================================================" +
                    "\n"
                    );
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");

                var postBody = new PostBody()
                {
                    Title = "Test Post",
                    Body = "Hello World",
                    UserId = 44
                };

                var postBodyJson = JsonConvert.SerializeObject(postBody);

                var payload = new StringContent(postBodyJson, Encoding.UTF8, "application/json");

                var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;

                Console.WriteLine(result);
            }
        }
    }
}
