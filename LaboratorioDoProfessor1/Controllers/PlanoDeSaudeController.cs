using LaboratorioDoProfessor1.Models;
using LaboratorioDoProfessor1.Services;
using Microsoft.AspNetCore.Mvc;

namespace LaboratorioDoProfessor1.Controllers
{
    public class PlanoDeSaudeController : Controller
    {
        private readonly PlanoDeSaudeService planoDeSaudeService;

        public PlanoDeSaudeController(PlanoDeSaudeService planoDeSaudeService)
        {
            this.planoDeSaudeService = planoDeSaudeService;
        }

        public IActionResult Listar()
        {
            return View(planoDeSaudeService.BuscarTodos());
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(PlanoDeSaude plano)
        {
            if (ModelState.IsValid)
            {
                planoDeSaudeService.Adicionar(plano);
                return RedirectToAction("Listar");
            }
            return View(plano);
        }
    }
}