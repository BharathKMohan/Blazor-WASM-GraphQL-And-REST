using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorAPIClient.DTOs;

namespace BlazorAPIClient.DataServices
{
    public class RESTSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient _httpClient;

        public RESTSpaceXDataService(HttpClient httpclient)
        {
            _httpClient = httpclient;
        }
        public async Task<List<LaunchDto>> GetAllLaunches()
        {
           return await this._httpClient.GetFromJsonAsync<List<LaunchDto>>("/rest/launches");
        }
    }
}