using Newtonsoft.Json;

namespace PokeDexMVC.Models
{
    public class DamageRelations
    {
        [JsonProperty("no_damage_to")]
        public List<Opponent> No_damage_to { get; set; }

        [JsonProperty("double_damage_to")]
        public List<Opponent> Double_damage_to { get; set; }

        [JsonProperty("no_damage_from")]
        public List<Opponent> No_damage_from { get; set; }

        [JsonProperty("double_damage_from")]
        public List<Opponent> Double_damage_from { get; set; }

    }
}
