using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;

namespace JSONhttp
{
    internal class Program
    {
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
        }

        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com/ ")
            };

            User user = await client.GetFromJsonAsync<User>("users/4");

            Console.WriteLine(user.Name);
        }
    }
}
