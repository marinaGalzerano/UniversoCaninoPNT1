using Microsoft.EntityFrameworkCore.Migrations;

namespace Prueba.Migrations
{
    public partial class PruebaContextUCaninoContext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmarPswd",
                table: "Usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmarPswd",
                table: "Usuarios");
        }
    }
}
