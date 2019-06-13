using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaboratorioDoProfessor1.Migrations
{
    public partial class paciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    PlanoDeSaudeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Planos_PlanoDeSaudeId",
                        column: x => x.PlanoDeSaudeId,
                        principalTable: "Planos",
                        principalColumn: "PlanoDeSaudeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_PlanoDeSaudeId",
                table: "Pacientes",
                column: "PlanoDeSaudeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
