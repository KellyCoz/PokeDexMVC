using Newtonsoft.Json;

namespace PokeDexMVC.Models
{
    public class DamageRelations
    {
        [JsonProperty("no_damage_to")]
        public Opponent No_damage_to { get; set; }

        [JsonProperty("double_damage_to")]
        public Opponent Double_damage_to { get; set; }

        [JsonProperty("no_damage_from")]
        public Opponent No_damage_from { get; set; }

        [JsonProperty("double_damage_from")]
        public Opponent Double_damage_from { get; set; }

    }
}
