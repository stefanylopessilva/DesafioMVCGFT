using System.Linq;
using ControleStarter.Data;
using ControleStarter.DTO;
using ControleStarter.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleStarter.Controllers
{
    [Authorize(Policy = "AcessoAdmin")]
    public class StarterController : Controller
    {
        private readonly ApplicationDbContext database;
        public StarterController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            var starters = database.Starters.Include("Tecnologia").Include("ProgramaStart").Include("Modulo").ToList();
            return View(starters);
        }
        public IActionResult NovoStarter()
        {
            ViewBag.Tecnologias = database.Tecnologias.ToList();
            ViewBag.ProgramaStarters = database.ProgramaStarters.ToList();
            ViewBag.Modulos = database.Modulos.ToList();
            return View();
        }
        public IActionResult EditarStarter(int id)
        {
            var starter = database.Starters.Include("Tecnologia").Include("ProgramaStart").Include("Modulo").First(starter => starter.Id == id);
            StarterDTO starterDTOView = new StarterDTO();
            starterDTOView.Id = starter.Id;
            starterDTOView.Nome = starter.Nome;
            starterDTOView.QuatroLetras = starter.QuatroLetras;
            starterDTOView.TecnologiaID = starter.Tecnologia.Id;
            starterDTOView.ProgramaStartID = starter.ProgramaStart.Id;
            starterDTOView.ModuloID = starter.Modulo.Id;

            ViewBag.Tecnologias = database.Tecnologias.ToList();
            ViewBag.ProgramaStarters = database.ProgramaStarters.ToList();
            ViewBag.Modulos = database.Modulos.ToList();
            return View(starterDTOView);
        }
        [HttpPost]
        public IActionResult Atualizar(StarterDTO starterDTO)
        {
            if (ModelState.IsValid)
            {
                var starter = database.Starters.First(starter => starter.Id == starterDTO.Id);
                starter.Nome = starterDTO.Nome;
                starter.QuatroLetras = starterDTO.QuatroLetras;
                starter.Tecnologia = database.Tecnologias.First(tecnologia => tecnologia.Id == starterDTO.TecnologiaID);
                starter.ProgramaStart = database.ProgramaStarters.First(programaStart => programaStart.Id == starterDTO.ProgramaStartID);
                starter.Modulo = database.Modulos.First(modulo => modulo.Id == starterDTO.ModuloID);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("EditarStarter");
            }
        }
        [HttpPost]
        public IActionResult Salvar(StarterDTO starterDTO)
        {
            if (ModelState.IsValid)
            {
                Starter starter = new Starter();
                starter.Nome = starterDTO.Nome;
                starter.QuatroLetras = starterDTO.QuatroLetras;
                starter.Tecnologia = database.Tecnologias.First(tecnologia => tecnologia.Id == starterDTO.TecnologiaID);
                starter.ProgramaStart = database.ProgramaStarters.First(programaStart => programaStart.Id == starterDTO.ProgramaStartID);
                starter.Modulo = database.Modulos.First(modulo => modulo.Id == starterDTO.ModuloID);
                database.Starters.Add(starter);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NovoStarter");
            }
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                Starter starter = database.Starters.First(registro => registro.Id == id);
                database.Starters.Remove(starter);
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