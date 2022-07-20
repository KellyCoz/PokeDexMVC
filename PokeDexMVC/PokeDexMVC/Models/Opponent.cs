using Newtonsoft.Json;

namespace PokeDexMVC.Models
{
    public class Opponent
    {
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

    }
}
