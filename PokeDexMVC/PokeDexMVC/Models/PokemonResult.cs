using Newtonsoft.Json;

namespace PokeDexMVC.Models
{
    public class PokemonResult
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("types")]
        public List<PokemonType>? Types { get; set; }
    }
}
