using Microsoft.EntityFrameworkCore.Migrations;

namespace LaboratorioDoProfessor1.Migrations
{
    public partial class ajustePlano : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RazaoSocial",
                table: "Planos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RazaoSocial",
                table: "Planos");
        }
    }
}
