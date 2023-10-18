using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProejtoFrontEnd.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Logs_UsuarioId",
                table: "Logs",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_UsuarioId",
                table: "Endereco",
                column: "UsuarioId",
                unique: true,
                filter: "[UsuarioId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Usuarios_UsuarioId",
                table: "Endereco",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Usuarios_UsuarioId",
                table: "Logs",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Usuarios_UsuarioId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Usuarios_UsuarioId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UsuarioId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_UsuarioId",
                table: "Endereco");
        }
    }
}
