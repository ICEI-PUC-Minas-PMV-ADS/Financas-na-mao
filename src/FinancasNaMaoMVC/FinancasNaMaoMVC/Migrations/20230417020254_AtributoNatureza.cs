using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancasNaMaoMVC.Migrations
{
    public partial class AtributoNatureza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_AspNetUsers_UsuarioId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Categorias_CategoriaID",
                table: "Lancamentos");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Lancamentos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaID",
                table: "Lancamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Natureza",
                table: "Lancamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_AspNetUsers_UsuarioId",
                table: "Lancamentos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Categorias_CategoriaID",
                table: "Lancamentos",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_AspNetUsers_UsuarioId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Categorias_CategoriaID",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "Natureza",
                table: "Lancamentos");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Lancamentos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaID",
                table: "Lancamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_AspNetUsers_UsuarioId",
                table: "Lancamentos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Categorias_CategoriaID",
                table: "Lancamentos",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
