using RestEase;

namespace PokeDexMVC.Models
{
    public class PokeApi
    {
        public interface IPokeApi
        {
            [Get("type/")]
            Task<Type> GetPokemonAsync([Path] string name);
        }

        public static IPokeApi Client()=>RestClient.For<IPokeApi>("https://pokeapi.co/api/v2");
        
    }
}
