using Newtonsoft.Json;

namespace PokeDexMVC.Models
{
    public class Pokemon
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string? PrimaryType { get; set; }
        public string? SecondaryType { get; set; }
        //the following properties are nullable and not required to create a pokemon
        public string? StronglyAttacks { get; set; }
        public string? WeaklyAttacks { get; set; }
        public string? StronglyDefends { get; set; }
        public string? WeaklyDefends { get; set; }

        //public void GetTypes(PokemonResult pokemonResult)
        //{
          //  PrimaryType = pokemonResult.Slots.FirstOrDefault().Type.Name;
        //}

        public void GetTypes(PokemonResult pokemonResult)
        {
            int cnt = pokemonResult.Slots.Count();
            int i = 0;
            SecondaryType = "none";
            while(i<cnt)
            {
                if(i==0)
                {
                    PrimaryType = pokemonResult.Slots[i].Type.Name;
                }
                if(i==1)
                {
                    SecondaryType = pokemonResult.Slots[i].Type.Name;
                }
                i++;

            }
        }

        public string GetStrongAttackType(OpponentType type)
        {
            //access the type object returned by the API, and follow the layers all the way down to the attribute we want to return 
            //in this case, the name stored in the specific levels of damage relations (double_damage_to, no_damage_to, etc.)

            int cnt = type.DamageRelations.Double_damage_to.Count();
            int i = 0;
            string sAttacks = "";
            while (i < cnt)
            {
                if (i == 0)
                {
                    sAttacks = type.DamageRelations.Double_damage_to[i].Name;
                }
                else
                {
                    sAttacks = sAttacks + ", " + type.DamageRelations.Double_damage_to[i].Name;
                }
                i++;
            }

            return sAttacks;
        }
        //public string GetConcatenated(OpponentType type, int num)
        //{
        //    num = type.DamageRelations.Double_damage_to.Count();
        //    int i = 0;
        //    string opponents = "";
        //    while (i < num)
        //    {
        //        if (i == 0)
        //        {
        //            opponents = type.DamageRelations.Double_damage_to[i].Name;
        //        }
        //        else
        //        {
        //            opponents = opponents + ", " + type.DamageRelations.Double_damage_to[i].Name;
        //        }
        //        i++;
        //    }
        //    return opponents;
        //   }
        public string GetWeakAttackType(OpponentType type)
        {
            int cnt = type.DamageRelations.No_damage_to.Count();
            int i = 0;
            string wAttacks = "";
            while (i < cnt)
            {
                if (i == 0)
                {
                    wAttacks = type.DamageRelations.No_damage_to[i].Name;
                }
                else
                {
                    wAttacks = wAttacks + ", " + type.DamageRelations.No_damage_to[i].Name;
                }
                i++;
            }

            return wAttacks;
        }
        public string GetStrongDefendType(OpponentType type)
        {
            int cnt = type.DamageRelations.No_damage_from.Count();
            int i = 0;
            string sDefends = "";
            while (i < cnt)
            {
                if (i == 0)
                {
                    sDefends = type.DamageRelations.No_damage_from[i].Name;
                }
                else
                {
                    sDefends = sDefends + ", " + type.DamageRelations.No_damage_from[i].Name;
                }
                i++;
            }

            return sDefends;
        }
        public string GetWeakDefendType(OpponentType type)
        {
            int cnt = type.DamageRelations.Double_damage_from.Count();
            int i = 0;
            string wDefends = "";
            while (i < cnt)
            {
                if (i == 0)
                {
                    wDefends = type.DamageRelations.Double_damage_from[i].Name;
                }
                else
                {
                    wDefends = wDefends + ", " + type.DamageRelations.Double_damage_from[i].Name;
                }
                i++;
            }
            return wDefends;
        }

    }

}
