using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokeDexMVC.Models
{
    public class Type
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("damage_relations")]
        public DamageRelations DamageRelations { get; set; }
    }
}
