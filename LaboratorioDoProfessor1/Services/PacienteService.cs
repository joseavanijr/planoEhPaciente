using LaboratorioDoProfessor1.Models;
using LaboratorioDoProfessor1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioDoProfessor1.Services
{
    public class PacienteService : ServiceBase<Paciente>
    {
        private readonly PacienteRepository pacienteRepository;

        public PacienteService(PacienteRepository pacienteRepository): base(pacienteRepository)
        {
            this.pacienteRepository = pacienteRepository;
        }

        public IList<Paciente> BuscarPorNome(string nome)
        {
            return pacienteRepository.GetByNome(nome);
        }

    }
}
