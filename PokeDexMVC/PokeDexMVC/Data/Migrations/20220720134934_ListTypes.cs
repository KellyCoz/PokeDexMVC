using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeDexMVC.Data.Migrations
{
    public partial class ListTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrimaryType",
                table: "Pokemons",
                newName: "Types");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Types",
                table: "Pokemons",
                newName: "PrimaryType");
        }
    }
}
