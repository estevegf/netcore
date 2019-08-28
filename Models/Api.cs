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
        private const string BaseUrl = "https://us-central1-tfg2019-ae3f8.cloudfunctions.net/api/";
        private readonly HttpClient _client;

        public Api(HttpClient client)
        {
            _client = client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("User-Agent", "Esteve Genovard Ferriol");
        }

        public async Task<Education[]> GetEducation()
        {
            var response = _client.GetStringAsync(BaseUrl + "education");
            var msg = await response;

            Education[] education = JsonConvert.DeserializeObject<Education[]>(msg);
            Console.Write("--------------Message------------------");
            Console.Write(JsonConvert.DeserializeObject<object>(msg));

            return education;
        }
    }
}
