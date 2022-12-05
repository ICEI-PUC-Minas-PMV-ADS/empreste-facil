using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresteFacil.Migrations
{
    public partial class Parcelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParcelaId",
                table: "Parcelas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmprestimoId",
                table: "Emprestimos",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Parcelas",
                newName: "ParcelaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Emprestimos",
                newName: "EmprestimoId");
        }
    }
}
