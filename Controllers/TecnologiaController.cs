using System.Linq;
using ControleStarter.Data;
using ControleStarter.DTO;
using ControleStarter.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleStarter.Controllers
{
    [Authorize(Policy = "AcessoAdmin")]
    public class TecnologiaController : Controller
    {
        private readonly ApplicationDbContext database;
        public TecnologiaController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            var tecnologias = database.Tecnologias.ToList();
            return View(tecnologias);
        }
        public IActionResult NovaTecnologia()
        {
            return View();
        }
        public IActionResult EditarTecnologia(int id)
        {
            var tecnologia = database.Tecnologias.First(tecnologia => tecnologia.Id == id);
            TecnologiaDTO tecnologiaDTOView = new TecnologiaDTO();
            tecnologiaDTOView.Id = tecnologia.Id;
            tecnologiaDTOView.Nome = tecnologia.Nome;
            tecnologiaDTOView.Descricao = tecnologia.Descricao;
            return View(tecnologiaDTOView);
        }
        [HttpPost]
        public IActionResult Atualizar(TecnologiaDTO tecnologiaDTO)
        {
            if (ModelState.IsValid)
            {
                var tecnologia = database.Tecnologias.First(tecnologia => tecnologia.Id == tecnologiaDTO.Id);
                tecnologia.Nome = tecnologiaDTO.Nome;
                tecnologia.Descricao = tecnologiaDTO.Descricao;
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("EditarTecnologia");
            }
        }
        [HttpPost]
        public IActionResult Salvar(TecnologiaDTO tecnologiaDTO)
        {
            if (ModelState.IsValid)
            {
                Tecnologia tecnologia = new Tecnologia();
                tecnologia.Nome = tecnologiaDTO.Nome;
                tecnologia.Descricao = tecnologiaDTO.Descricao;
                database.Tecnologias.Add(tecnologia);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NovaTecnologia");
            }
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                Tecnologia tecnologia = database.Tecnologias.First(registro => registro.Id == id);
                database.Tecnologias.Remove(tecnologia);
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