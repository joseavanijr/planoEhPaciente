using LaboratorioDoProfessor1.Models;
using LaboratorioDoProfessor1.Repositories;
using System.Collections.Generic;

namespace LaboratorioDoProfessor1.Services
{
    public class PlanoDeSaudeService: ServiceBase<PlanoDeSaude>
    {
        private readonly PlanoDeSaudeRepository planoDeSaudeRepository;

        public PlanoDeSaudeService(PlanoDeSaudeRepository repository):base(repository)
        {
            this.planoDeSaudeRepository = repository;
        }

        public IList<PlanoDeSaude> BuscaPorDescricao(string descricao)
        {
            return planoDeSaudeRepository.GetByDescricao(descricao);
        }

    }
}
