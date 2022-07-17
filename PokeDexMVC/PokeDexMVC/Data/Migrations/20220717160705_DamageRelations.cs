using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeDexMVC.Data.Migrations
{
    public partial class DamageRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Type_Pokemons_PokemonId",
                table: "Type");

            migrationBuilder.DropForeignKey(
                name: "FK_Type_Pokemons_PokemonId1",
                table: "Type");

            migrationBuilder.DropForeignKey(
                name: "FK_Type_Pokemons_PokemonId2",
                table: "Type");

            migrationBuilder.DropForeignKey(
                name: "FK_Type_Pokemons_PokemonId3",
                table: "Type");

            migrationBuilder.DropForeignKey(
                name: "FK_Type_Pokemons_PokemonId4",
                table: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Type_PokemonId",
                table: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Type_PokemonId1",
                table: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Type_PokemonId2",
                table: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Type_PokemonId3",
                table: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Type_PokemonId4",
                table: "Type");

            migrationBuilder.DropColumn(
                name: "PokemonId",
                table: "Type");

            migrationBuilder.DropColumn(
                name: "PokemonId1",
                table: "Type");

            migrationBuilder.DropColumn(
                name: "PokemonId2",
                table: "Type");

            migrationBuilder.DropColumn(
                name: "PokemonId3",
                table: "Type");

            migrationBuilder.DropColumn(
                name: "PokemonId4",
                table: "Type");

            migrationBuilder.DropColumn(
                name: "Health",
                table: "Pokemons");

            migrationBuilder.CreateTable(
                name: "PokemonType",
                columns: table => new
                {
                    PokemonsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonType", x => new { x.PokemonsId, x.TypesId });
                    table.ForeignKey(
                        name: "FK_PokemonType_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonType_Type_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonType_TypesId",
                table: "PokemonType",
                column: "TypesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonType");

            migrationBuilder.AddColumn<Guid>(
                name: "PokemonId",
                table: "Type",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PokemonId1",
                table: "Type",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PokemonId2",
                table: "Type",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PokemonId3",
                table: "Type",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PokemonId4",
                table: "Type",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Health",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Type_Pokemons_PokemonId",
                table: "Type",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Type_Pokemons_PokemonId1",
                table: "Type",
                column: "PokemonId1",
                principalTable: "Pokemons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Type_Pokemons_PokemonId2",
                table: "Type",
                column: "PokemonId2",
                principalTable: "Pokemons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Type_Pokemons_PokemonId3",
                table: "Type",
                column: "PokemonId3",
                principalTable: "Pokemons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Type_Pokemons_PokemonId4",
                table: "Type",
                column: "PokemonId4",
                principalTable: "Pokemons",
                principalColumn: "Id");
        }
    }
}
