namespace PokeDexMVC.Models
{
    public class Pokemon
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Type { get; set; }
        public List<String> StronglyAttacks { get; set; }
        public List<String> WeaklyAttacks { get; set; }
        public List<String> StronglyDefends { get; set; }
        public List<String> WeaklyDefends { get; set; }

        public List<String> GetStrongEnemies(String Type)
        {
            return StronglyAttacks;
        }
        public List<String> GetWeakEnemies(String Type)
        {
            return WeaklyAttacks;
        }
    }
}
