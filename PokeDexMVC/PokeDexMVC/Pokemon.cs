namespace PokeDexMVC
{
    public class Pokemon
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Type { get; set; }
        public string StronglyAttacks { get; set; }
        public string WeaklyAttacks { get; set; }
        public string StronglyDefends { get; set; }
        public string WeaklyDefends { get; set; }
    }
}
