using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokeDexMVC.Models
{
    public class OpponentType : PokemonType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        //damage_relations is an object, denoted by {} in the api documentation, not a list which is denoted by []
        [JsonProperty("damage_relations")]
        public DamageRelations DamageRelations { get; set; }
    }
}
