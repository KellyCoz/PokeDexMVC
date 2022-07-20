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
            Type = pokemonResult.Slots.FirstOrDefault().Type.Name;
        }
        public List<Opponent> GetListOfStrongAttack (OpponentType type)
        {
            List<Opponent> LofStronglyAttacks = type.DamageRelations.Double_damage_to;
            return LofStronglyAttacks;

        }
        
        public string GetStrongAttackType(OpponentType type)
        {
            //access the type object returned by the API, and follow the layers all the way down to the attribute we want to return 
            //in this case, the name stored in the specific levels of damage relations (double_damage_to, no_damage_to, etc.)
            string sAttacks = type.DamageRelations.Double_damage_to.FirstOrDefault()?.Name;
            return sAttacks;

        }
        public string GetWeakAttackType(OpponentType type)
        {
            string wAttacks = type.DamageRelations.No_damage_to.FirstOrDefault()?.Name; 
            return wAttacks;
        }
        public string GetStrongDefendType(OpponentType type)
        {
            string sDefends = type.DamageRelations.No_damage_from.FirstOrDefault()?.Name;
            return sDefends;
        }
        public string GetWeakDefendType(OpponentType type)
        {
            string wDefends = type.DamageRelations.Double_damage_from.FirstOrDefault()?.Name;
            return wDefends;
        }

    }

}
