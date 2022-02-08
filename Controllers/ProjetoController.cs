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
    public class ProjetoController : Controller
    {
        private readonly ApplicationDbContext database;
        public ProjetoController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            var projetos = database.Projetos.Include("Starter").Include("Modulo").ToList();
            return View(projetos);
        }
        public IActionResult NovoProjeto()
        {
            ViewBag.Starters = database.Starters.ToList();
            ViewBag.Modulos = database.Modulos.ToList();
            return View();
        }
        public IActionResult EditarProjeto(int id)
        {
            var projeto = database.Projetos.Include("Starter").Include("Modulo").First(projeto => projeto.Id == id);
            ProjetoDTO projetoDTOView = new ProjetoDTO();
            projetoDTOView.Id = projeto.Id;
            projetoDTOView.Avaliacao = projeto.Avaliacao;
            projetoDTOView.StarterID = projeto.Starter.Id;
            projetoDTOView.ModuloID = projeto.Modulo.Id;

            ViewBag.Starters = database.Starters.ToList();
            ViewBag.Modulos = database.Modulos.ToList();
            return View(projetoDTOView);
        }
        [HttpPost]
        public IActionResult Atualizar(ProjetoDTO projetoDTO)
        {
            if (ModelState.IsValid)
            {
                var projeto = database.Projetos.First(projeto => projeto.Id == projetoDTO.Id);
                projeto.Avaliacao = projetoDTO.Avaliacao;
                projeto.Modulo = database.Modulos.First(modulo => modulo.Id == projetoDTO.ModuloID);
                projeto.Starter = database.Starters.First(starter => starter.Id == projetoDTO.StarterID);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("EditarProjeto");
            }
        }
        [HttpPost]
        public IActionResult Salvar(ProjetoDTO projetoDTO)
        {
            if (ModelState.IsValid)
            {
                Projeto projeto = new Projeto();
                projeto.Avaliacao = projetoDTO.Avaliacao;
                projeto.Modulo = database.Modulos.First(modulo => modulo.Id == projetoDTO.ModuloID);
                projeto.Starter = database.Starters.First(starter => starter.Id == projetoDTO.StarterID);
                database.Projetos.Add(projeto);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NovoProjeto");
            }
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                Projeto projeto = database.Projetos.First(registro => registro.Id == id);
                database.Projetos.Remove(projeto);
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