using RestEase;
using PokeDexMVC.Models;

namespace PokeDexMVC
{
    public class PokeApi
    {
        public interface IPokeApi
        {
            //the pokeApi requires a path variable, in this case either {id} or {name}. I'm using name as its not likely i'll know the id
            [Get("type/{name}")]
            Task<Models.OpponentType> GetTypesAsync([Path] string name);

            [Get("pokemon/{name}")]
            Task<PokemonResult> GetPokemonAsync([Path] string name);
        }

        public static IPokeApi Client() => RestClient.For<IPokeApi>("https://pokeapi.co/api/v2/");

    }
}
