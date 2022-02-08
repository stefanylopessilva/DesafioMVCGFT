using System.Collections.Generic;
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
    public class GrupoController : Controller
    {
        private readonly ApplicationDbContext database;
        public GrupoController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            var grupos = database.Grupos.Include("Tecnologia").ToList();
            return View(grupos);
        }
        public IActionResult NovoGrupo()
        {
            ViewBag.Starters = database.Starters.ToList();
            ViewBag.Tecnologias = database.Tecnologias.ToList();
            return View();
        }
        public IActionResult EditarGrupo(int id)
        {
            var grupo = database.Grupos.Include("Tecnologia").First(grupo => grupo.Id == id);
            GrupoDTO grupoDTOView = new GrupoDTO();
            grupoDTOView.Id = grupo.Id;
            grupoDTOView.ScrumMaster = grupo.ScrumMaster;
            grupoDTOView.TecnologiaID = grupo.Tecnologia.Id;

            ViewBag.Starters = database.Starters.ToList();
            ViewBag.Tecnologias = database.Tecnologias.ToList();
            return View(grupoDTOView);
        }
        [HttpPost]
        public IActionResult Atualizar(GrupoDTO grupoDTO)
        {
            if (ModelState.IsValid)
            {
                var grupo = database.Grupos.First(grupo => grupo.Id == grupoDTO.Id);
                grupo.ScrumMaster = grupoDTO.ScrumMaster;
                grupo.Tecnologia = database.Tecnologias.First(tecnologia => tecnologia.Id == grupoDTO.TecnologiaID);
                database.SaveChanges();
                List<Starter> listaDeStarter = new List<Starter>();

                foreach (var starterID in grupoDTO.StartersID)
                {
                    var starterDaBase = database.Starters.First(starter => starter.Id == starterID);
                    starterDaBase.Grupo = grupo;
                    database.Starters.Update(starterDaBase);
                }
                database.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View("EditarGrupo");
            }
        }
        [HttpPost]
        public IActionResult Salvar(GrupoDTO grupoDTO)
        {
            if (ModelState.IsValid)
            {
                Grupo grupo = new Grupo();
                grupo.ScrumMaster = grupoDTO.ScrumMaster;
                grupo.Tecnologia = database.Tecnologias.First(tecnologia => tecnologia.Id == grupoDTO.TecnologiaID);
                database.Grupos.Add(grupo);
                database.SaveChanges();
                List<Starter> listaDeStarter = new List<Starter>();

                foreach (var starterID in grupoDTO.StartersID)
                {
                    var starterDaBase = database.Starters.First(starter => starter.Id == starterID);
                    starterDaBase.Grupo = grupo;
                    database.Starters.Update(starterDaBase);
                }
                database.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View("NovoGrupo");
            }
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                Grupo grupo = database.Grupos.First(registro => registro.Id == id);
                database.Grupos.Remove(grupo);
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