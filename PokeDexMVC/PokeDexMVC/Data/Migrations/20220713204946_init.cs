using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeDexMVC.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokemonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PokemonId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PokemonId2 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PokemonId3 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PokemonId4 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Type_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Type_Pokemons_PokemonId1",
                        column: x => x.PokemonId1,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Type_Pokemons_PokemonId2",
                        column: x => x.PokemonId2,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Type_Pokemons_PokemonId3",
                        column: x => x.PokemonId3,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Type_Pokemons_PokemonId4",
                        column: x => x.PokemonId4,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Type_PokemonId",
                table: "Type",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Type_PokemonId1",
                table: "Type",
                column: "PokemonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Type_PokemonId2",
                table: "Type",
                column: "PokemonId2");

            migrationBuilder.CreateIndex(
                name: "IX_Type_PokemonId3",
                table: "Type",
                column: "PokemonId3");

            migrationBuilder.CreateIndex(
                name: "IX_Type_PokemonId4",
                table: "Type",
                column: "PokemonId4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
