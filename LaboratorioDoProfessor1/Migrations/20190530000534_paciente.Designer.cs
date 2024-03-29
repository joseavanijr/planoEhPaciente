﻿// <auto-generated />
using System;
using LaboratorioDoProfessor1.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LaboratorioDoProfessor1.Migrations
{
    [DbContext(typeof(LabContext))]
    [Migration("20190530000534_paciente")]
    partial class paciente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LaboratorioDoProfessor1.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome");

                    b.Property<int?>("PlanoDeSaudeId");

                    b.HasKey("Id");

                    b.HasIndex("PlanoDeSaudeId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("LaboratorioDoProfessor1.Models.PlanoDeSaude", b =>
                {
                    b.Property<int>("PlanoDeSaudeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.HasKey("PlanoDeSaudeId");

                    b.ToTable("Planos");
                });

            modelBuilder.Entity("LaboratorioDoProfessor1.Models.Paciente", b =>
                {
                    b.HasOne("LaboratorioDoProfessor1.Models.PlanoDeSaude", "PlanoDeSaude")
                        .WithMany()
                        .HasForeignKey("PlanoDeSaudeId");
                });
#pragma warning restore 612, 618
        }
    }
}
