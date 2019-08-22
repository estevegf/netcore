using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace netcore_project.Models
{
    public class Api : IApi
    {
        private const string BaseUrl = "https://api.github.com/";
        private readonly HttpClient _client;

        public Api(HttpClient client)
        {
            _client = client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("User-Agent", "Esteve Genovard Ferriol");
        }

        public async Task<int> GetStars()
        {
            var response = _client.GetStringAsync(BaseUrl + "repos/aspnet/AspNetCore");
            var msg = await response;
            var objectMsg = JsonConvert.DeserializeObject<Git>(msg);
            Console.Write("--------------Message------------------");
            Console.Write(JsonConvert.DeserializeObject<object>(msg));

            return objectMsg.Stargazers_count;
        }
    }
}
