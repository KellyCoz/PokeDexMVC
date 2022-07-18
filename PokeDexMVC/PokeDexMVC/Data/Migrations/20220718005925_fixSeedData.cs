using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeDexMVC.Data.Migrations
{
    public partial class fixSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "elementType",
                table: "Pokemons",
                newName: "WeaklyDefends");

            migrationBuilder.AddColumn<string>(
                name: "StronglyAttacks",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StronglyDefends",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeaklyAttacks",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("249a4472-9ef1-4a20-9d77-dfb66994bca2"),
                columns: new[] { "StronglyAttacks", "StronglyDefends", "Type", "WeaklyAttacks", "WeaklyDefends" },
                values: new object[] { "", "", "Electric", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StronglyAttacks",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "StronglyDefends",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "WeaklyAttacks",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "WeaklyDefends",
                table: "Pokemons",
                newName: "elementType");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("249a4472-9ef1-4a20-9d77-dfb66994bca2"),
                column: "elementType",
                value: "Electric");
        }
    }
}
