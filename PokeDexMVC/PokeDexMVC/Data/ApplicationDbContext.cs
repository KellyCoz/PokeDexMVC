using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PokeDexMVC.Models;

namespace PokeDexMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>().HasData(new Pokemon
            {
                Id = Guid.Parse("249a4472-9ef1-4a20-9d77-dfb66994bca2"),
                Name = "Pikachu",
                Type = "Electric",
                StronglyAttacks = "",
                StronglyDefends = "",
                WeaklyAttacks = "",
                WeaklyDefends = ""
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}