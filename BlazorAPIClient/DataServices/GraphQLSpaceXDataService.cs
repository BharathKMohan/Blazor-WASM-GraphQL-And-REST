using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorAPIClient.DTOs;

namespace BlazorAPIClient.DataServices
{
    public class GraphQLSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient httpClient;

        public GraphQLSpaceXDataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public  async Task<List<LaunchDto>> GetAllLaunches()
        {
            var queryObject = new {
                query = @"{  launches{  id is_tentative mission_name launch_date_local }}",
                variables = new {}
            };

            StringContent launchQuery = new StringContent(
                JsonSerializer.Serialize(queryObject),
                Encoding.UTF8,
                "application/json"
            );

           var response = await this.httpClient.PostAsync("graphql",launchQuery);

           if(response.IsSuccessStatusCode){
               var gqlData = await JsonSerializer.DeserializeAsync<GqlData>
                    (await response.Content.ReadAsStreamAsync());

                return gqlData.Data.Launches;
           }

           return null;
        }
    }
}