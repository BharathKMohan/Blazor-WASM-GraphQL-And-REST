using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorAPIClient.DTOs
{
    public class GqlData
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

        public partial class Data
    {
        [JsonPropertyName("launches")]
        public List<LaunchDto> Launches { get; set; }
    }
}