using LaboratorioDoProfessor1.Contexts;
using LaboratorioDoProfessor1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioDoProfessor1.Repositories
{
    public class PacienteRepository: RepositoryBase<Paciente>
    {
        public readonly LabContext db;

        public PacienteRepository(LabContext db):base(db)
        {
            this.db = db;
        }

        public IList<Paciente> GetByNome(string nome)
        {
            return db.Pacientes.Where(p => p.Nome.Contains(nome)).Include(p=>p.PlanoDeSaude).ToList();
        }

        public override IList<Paciente> FindAll()
        {
            return db.Pacientes.Include(p=>p.PlanoDeSaude).ToList();
        }

        public override Paciente GetById(int id)
        {
            return db.Pacientes.Include(p=>p.PlanoDeSaude).FirstOrDefault(p => p.Id == id);
        }
    }
}
