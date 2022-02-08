using System.Linq;
using ControleStarter.Data;
using ControleStarter.DTO;
using ControleStarter.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleStarter.Controllers
{
    [Authorize]
    public class DailyController : Controller
    {
        private readonly ApplicationDbContext database;
        public DailyController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            var dailys = database.Dailys.Include("Grupo").Include("Modulo").Include("Starter").ToList();
            return View(dailys);
        }
        public IActionResult NovaDaily()
        {
            ViewBag.Grupos = database.Grupos.ToList();
            ViewBag.Modulos = database.Modulos.ToList();
            ViewBag.Starters = database.Starters.ToList();
            return View();
        }
        public IActionResult EditarDaily(int id)
        {
            var daily = database.Dailys.Include("Grupo").Include("Starter").Include("Modulo").First(daily => daily.Id == id);
            DailyDTO dailyDTOView = new DailyDTO();
            dailyDTOView.Id = daily.Id;
            dailyDTOView.GrupoID = daily.Grupo.Id;
            dailyDTOView.StarterID = daily.Starter.Id;
            dailyDTOView.Data = daily.Data;
            dailyDTOView.Fazendo = daily.Fazendo;
            dailyDTOView.Feito = daily.Feito;
            dailyDTOView.Impedimentos = daily.Impedimentos;
            dailyDTOView.Presenca = daily.Presenca;
            dailyDTOView.ModuloID = daily.Modulo.Id;

            ViewBag.Grupos = database.Grupos.ToList();
            ViewBag.Modulos = database.Modulos.ToList();
            ViewBag.Starters = database.Starters.ToList();
            return View(dailyDTOView);
        }
        [HttpPost]
        public IActionResult Atualizar(DailyDTO dailyDTO)
        {
            if (ModelState.IsValid)
            {
                var daily = database.Dailys.First(daily => daily.Id == dailyDTO.Id);
                daily.Data = dailyDTO.Data;
                daily.Fazendo = dailyDTO.Fazendo;
                daily.Feito = dailyDTO.Feito;
                daily.Impedimentos = dailyDTO.Impedimentos;
                daily.Presenca = dailyDTO.Presenca;
                daily.Grupo = database.Grupos.First(grupo => grupo.Id == dailyDTO.GrupoID);
                daily.Modulo = database.Modulos.First(modulo => modulo.Id == dailyDTO.ModuloID);
                daily.Starter = database.Starters.First(starter => starter.Id == dailyDTO.StarterID);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("EditarDaily");
            }
        }
        [HttpPost]
        public IActionResult Salvar(DailyDTO dailyDTO)
        {
            if (ModelState.IsValid)
            {
                Daily daily = new Daily();
                daily.Data = dailyDTO.Data;
                daily.Fazendo = dailyDTO.Fazendo;
                daily.Feito = dailyDTO.Feito;
                daily.Impedimentos = dailyDTO.Impedimentos;
                daily.Presenca = dailyDTO.Presenca;
                daily.Grupo = database.Grupos.First(grupo => grupo.Id == dailyDTO.GrupoID);
                daily.Modulo = database.Modulos.First(modulo => modulo.Id == dailyDTO.ModuloID);
                daily.Starter = database.Starters.First(starter => starter.Id == dailyDTO.StarterID);
                database.Dailys.Add(daily);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NovaDaily");
            }
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                Daily daily = database.Dailys.First(registro => registro.Id == id);
                database.Dailys.Remove(daily);
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