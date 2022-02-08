using System.Linq;
using ControleStarter.Data;
using ControleStarter.DTO;
using ControleStarter.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleStarter.Controllers
{
    [Authorize(Policy = "AcessoAdmin")]
    public class ProgramaStartController : Controller
    {
        private readonly ApplicationDbContext database;
        public ProgramaStartController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            var programaStarters = database.ProgramaStarters.ToList();
            return View(programaStarters);
        }
        public IActionResult NovaTurma()
        {
            return View();
        }
        public IActionResult EditarProgramaStart(int id)
        {
            var programaStart = database.ProgramaStarters.First(programaStart => programaStart.Id == id);
            ProgramaStartDTO programaStartDTOView = new ProgramaStartDTO();
            programaStartDTOView.Id = programaStart.Id;
            programaStartDTOView.Nome = programaStart.Nome;
            programaStartDTOView.DataInicial = programaStart.DataInicial;
            programaStartDTOView.DataFinal = programaStart.DataFinal;
            return View(programaStartDTOView);
        }
        [HttpPost]
        public IActionResult Atualizar(ProgramaStartDTO programaStartDTO)
        {
            if (ModelState.IsValid)
            {
                var programaStart = database.ProgramaStarters.First(programaStart => programaStart.Id == programaStartDTO.Id);
                programaStart.Id = programaStartDTO.Id;
                programaStart.Nome = programaStartDTO.Nome;
                programaStart.DataInicial = programaStartDTO.DataInicial;
                programaStart.DataFinal = programaStartDTO.DataFinal;
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("EditarProgramaStart");
            }
        }
        [HttpPost]
        public IActionResult Salvar(ProgramaStartDTO programaStartDTO)
        {
            if (ModelState.IsValid)
            {
                ProgramaStart programaStart = new ProgramaStart();
                programaStart.Nome = programaStartDTO.Nome;
                programaStart.DataInicial = programaStartDTO.DataInicial;
                programaStart.DataFinal = programaStartDTO.DataFinal;
                database.ProgramaStarters.Add(programaStart);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NovaTurma");
            }
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                ProgramaStart programaStart = database.ProgramaStarters.First(registro => registro.Id == id);
                database.ProgramaStarters.Remove(programaStart);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (System.Exception)
            {
                return View("../Shared/ErroApagar");
            }
        }
    }
}