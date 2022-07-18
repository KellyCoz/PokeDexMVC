using RestEase;
using PokeDexMVC.Models;

namespace PokeDexMVC
{
    public class PokeApi
    {
        public interface IPokeApi
        {
            [Get("type/{name}")]
            Task<Models.Type> GetTypesAsync([Path] string name);
        }

        public static IPokeApi Client() => RestClient.For<IPokeApi>("https://pokeapi.co/api/v2/");

    }
}
