using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeDexMVC.Data.Migrations
{
    public partial class FinalFixes_maybe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Types",
                table: "Pokemons",
                newName: "SecondaryType");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryType",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("249a4472-9ef1-4a20-9d77-dfb66994bca2"),
                columns: new[] { "PrimaryType", "SecondaryType" },
                values: new object[] { "Electric", "normal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryType",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "SecondaryType",
                table: "Pokemons",
                newName: "Types");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: new Guid("249a4472-9ef1-4a20-9d77-dfb66994bca2"),
                column: "Types",
                value: "Electric");
        }
    }
}
