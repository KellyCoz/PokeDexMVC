using Newtonsoft.Json;

namespace PokeDexMVC.Models
{
    public class PokemonType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
