using System.Linq;
using ControleStarter.Data;
using ControleStarter.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleStarter.Controllers
{
    [Authorize(Policy = "AcessoAdmin")]
    public class RelatorioController : Controller
    {
        private readonly ApplicationDbContext database;
        public RelatorioController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SelecionaTurma()
        {
            ViewBag.ProgramaStarters = database.ProgramaStarters.ToList();
            return View();
        } 
        public IActionResult SelecionaStarter()
        {
            ViewBag.Starters = database.Starters.ToList();
            return View();
        } 
        [HttpPost]
        public IActionResult RelatorioListaStarter(StarterDTO starterDTO)
        {
            var starterTurma = database.Starters.Include("ProgramaStart").Where(starter => starter.ProgramaStart.Id == starterDTO.ProgramaStartID);
            return View(starterTurma);
        }        
        public IActionResult RelatorioAvaliacaoStarter(ProjetoDTO projetoDTO)
        {
            var starterAvaliacao = database.Projetos.Include("Starter").Include("Modulo").Where(projeto => projeto.Starter.Id == projetoDTO.StarterID);
            return View(starterAvaliacao);
        }
    }
}