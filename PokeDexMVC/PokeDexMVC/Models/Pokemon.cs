using Newtonsoft.Json;

namespace PokeDexMVC.Models
{
    public class Pokemon
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public String? Type { get; set; }
        //the following properties are nullable and not required to create a pokemon
        public string? StronglyAttacks { get; set; }
        public string? WeaklyAttacks { get; set; }
        public string? StronglyDefends { get; set; }
        public string? WeaklyDefends { get; set; }

        public void GetTypes(PokemonResult pokemonResult)
        {
            Type = pokemonResult.Types.FirstOrDefault().Name;
        }
        public void MapType(OpponentType type)
        {
            //access the type object returned by the API, and follow the layers all the way down to the attribute we want to return 
            //in this case, the name stored in the specific levels of damage relations (double_damage_to, no_damage_to, etc.)
            StronglyAttacks = type.DamageRelations.Double_damage_to.FirstOrDefault()?.Name;
           
            WeaklyAttacks = type.DamageRelations.No_damage_to.FirstOrDefault()?.Name;
          
            StronglyDefends = type.DamageRelations.No_damage_from.FirstOrDefault()?.Name;
            
            WeaklyDefends = type.DamageRelations.Double_damage_from.FirstOrDefault()?.Name;
        }
    }

}
