using LaboratorioDoProfessor1.Contexts;
using LaboratorioDoProfessor1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioDoProfessor1.Repositories
{
    public class PlanoDeSaudeRepository:RepositoryBase<PlanoDeSaude>
    {
        private readonly LabContext db;

        public PlanoDeSaudeRepository(LabContext db):base(db)
        {
            this.db = db;
        }
     
        public IList<PlanoDeSaude> GetByDescricao(string descricao)
        {
            return db.Planos.Where(p => p.Descricao.Contains(descricao)).ToList();
        } 
        
        public override IList<PlanoDeSaude> FindAll()
        {
            return db.Planos.ToList();
        }

        public override PlanoDeSaude GetById(int id)
        {
            return db.Planos.FirstOrDefault(p=> p.PlanoDeSaudeId==id);
        }

    }
}
