using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioDoProfessor1.Models;
using LaboratorioDoProfessor1.Services;
using Microsoft.AspNetCore.Mvc;

namespace LaboratorioDoProfessor1.Controllers
{
    public class PacienteController : Controller
    {
        private readonly PacienteService pacienteService;

        public PacienteController(PacienteService pacienteService)
        {
            this.pacienteService = pacienteService;
        }

        public JsonResult Index()
        {
            IList<Paciente> lista = pacienteService.BuscarTodos();
            return Json(lista);
        }

        public JsonResult BuscarPorNome(string nome)
        {
            IList<Paciente> lista = pacienteService.BuscarPorNome(nome);
            return Json(lista);
        }
    }
}