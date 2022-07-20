using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeDexMVC.Data.Migrations
{
    public partial class PrimaryType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Opponent");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Pokemons",
                newName: "StronglyAttacks");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryType",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("249a4472-9ef1-4a20-9d77-dfb66994bca2"),
                columns: new[] { "PrimaryType", "StronglyAttacks" },
                values: new object[] { "Electric", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryType",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "StronglyAttacks",
                table: "Pokemons",
                newName: "Type");

            migrationBuilder.CreateTable(
                name: "Opponent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opponent_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("249a4472-9ef1-4a20-9d77-dfb66994bca2"),
                column: "Type",
                value: "Electric");

            migrationBuilder.CreateIndex(
                name: "IX_Opponent_PokemonId",
                table: "Opponent",
                column: "PokemonId");
        }
    }
}
