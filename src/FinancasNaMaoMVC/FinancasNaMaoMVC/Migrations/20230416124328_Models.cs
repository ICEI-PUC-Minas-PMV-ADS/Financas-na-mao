using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancasNaMaoMVC.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categorias_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lancamentos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    ValorReservado = table.Column<double>(type: "float", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isFixo = table.Column<bool>(type: "bit", nullable: false),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamentos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lancamentos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lancamentos_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_UsuarioId",
                table: "Categorias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_CategoriaID",
                table: "Lancamentos",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_UsuarioId",
                table: "Lancamentos",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamentos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
