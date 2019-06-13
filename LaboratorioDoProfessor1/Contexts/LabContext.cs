using LaboratorioDoProfessor1.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioDoProfessor1.Contexts
{
    public class LabContext : DbContext
    {
        public LabContext(DbContextOptions<LabContext> opcoes) : base (opcoes)
        {
        }
       
        public DbSet<PlanoDeSaude> Planos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

    }
}
