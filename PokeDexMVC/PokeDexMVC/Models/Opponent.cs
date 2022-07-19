using Newtonsoft.Json;

namespace PokeDexMVC.Models
{
    public class Opponent
    {
        [JsonProperty("name")]
        public string? Name { get; set; } = "none";

        [JsonProperty("url")]
        public string Url { get; set; }

    }
}
