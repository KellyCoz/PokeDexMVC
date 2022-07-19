using Newtonsoft.Json;

namespace PokeDexMVC.Models
{
    public class Slot
    {
        [JsonProperty("slot")]
        public int Rank { get; set; }
        [JsonProperty("type")]
        public PokemonType Type { get; set; }
    }
}
