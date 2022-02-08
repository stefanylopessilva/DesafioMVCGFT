using System.Linq;
using ControleStarter.Data;
using ControleStarter.DTO;
using ControleStarter.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleStarter.Controllers
{
    [Authorize(Policy = "AcessoAdmin")]
    public class ModuloController : Controller
    {
        private readonly ApplicationDbContext database;
        public ModuloController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            var modulos = database.Modulos.ToList();
            return View(modulos);
        }
        public IActionResult NovoModulo()
        {
            return View();
        }
        public IActionResult EditarModulo(int id)
        {
            var modulo = database.Modulos.First(modulo => modulo.Id == id);
            ModuloDTO moduloDTOView = new ModuloDTO();
            moduloDTOView.Id = modulo.Id;
            moduloDTOView.Nome = modulo.Nome;
            moduloDTOView.Projeto = modulo.Projeto;

            return View(moduloDTOView);
        }
        [HttpPost]
        public IActionResult Atualizar(ModuloDTO moduloDTO)
        {
            if (ModelState.IsValid)
            {
                var modulo = database.Modulos.First(modulo => modulo.Id == moduloDTO.Id);
                modulo.Nome = moduloDTO.Nome;
                modulo.Projeto = moduloDTO.Projeto;
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("EditarModulo");
            }
        }
        [HttpPost]
        public IActionResult Salvar(ModuloDTO moduloDTO)
        {
            if (ModelState.IsValid)
            {
                Modulo modulo = new Modulo();
                modulo.Nome = moduloDTO.Nome;
                modulo.Projeto = moduloDTO.Projeto;
                database.Modulos.Add(modulo);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NovoModulo");
            }
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                Modulo modulo = database.Modulos.First(registro => registro.Id == id);
                database.Modulos.Remove(modulo);
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