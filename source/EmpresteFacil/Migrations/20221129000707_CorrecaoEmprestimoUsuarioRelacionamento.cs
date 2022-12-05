using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresteFacil.Migrations
{
    public partial class CorrecaoEmprestimoUsuarioRelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Emprestimos");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Emprestimos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_UsuarioId",
                table: "Emprestimos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimos_AspNetUsers_UsuarioId",
                table: "Emprestimos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimos_AspNetUsers_UsuarioId",
                table: "Emprestimos");

            migrationBuilder.DropIndex(
                name: "IX_Emprestimos_UsuarioId",
                table: "Emprestimos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Emprestimos");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Emprestimos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
