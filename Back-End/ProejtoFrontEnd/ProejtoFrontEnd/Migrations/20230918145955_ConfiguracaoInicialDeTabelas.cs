using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProejtoFrontEnd.Migrations
{
    /// <inheritdoc />
    public partial class ConfiguracaoInicialDeTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Documento = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rua = table.Column<string>(type: "varchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "varchar(max)", nullable: true),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true),
                    Sexo = table.Column<string>(type: "varchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Fixo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeMaterno = table.Column<string>(type: "varchar(max)", nullable: true),
                    Login = table.Column<string>(type: "varchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "varchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    CodigoDeValidacao = table.Column<string>(type: "varchar(max)", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
