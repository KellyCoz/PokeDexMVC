using RestEase;
using PokeDexMVC.Models;

namespace PokeDexMVC
{
    public class PokeApi
    {
        public interface IPokeApi
        {
            [Get("type")]
            Task<Models.Type> GetTypesAsync();
        }

        public static IPokeApi Client() => RestClient.For<IPokeApi>("https://pokeapi.co/api/v2/");

    }
}
