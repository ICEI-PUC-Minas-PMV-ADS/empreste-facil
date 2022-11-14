using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresteFacil.Migrations
{
    public partial class Ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "PessoasFisicas");

            migrationBuilder.AddColumn<int>(
                name: "Perfil",
                table: "PessoasFisicas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "PessoasFisicas");

            migrationBuilder.AddColumn<bool>(
                name: "Tipo",
                table: "PessoasFisicas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
