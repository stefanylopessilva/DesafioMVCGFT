using System;
using System.Linq;
using ControleStarter.Data;
using ControleStarter.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleStarter.Controllers
{
    public class PopularBancoController :Controller
    {
        private readonly ApplicationDbContext database;
        public PopularBancoController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Popular()
        {
            var existeTecnologiaNoBanco = database.Tecnologias.ToList().Count == 0;
            var existeProgramaStartNoBanco = database.ProgramaStarters.ToList().Count == 0;
            var existeModuloNoBanco = database.Modulos.ToList().Count == 0;
            var existeStarterNoBanco = database.Starters.ToList().Count == 0;

            if (existeTecnologiaNoBanco && existeProgramaStartNoBanco && existeModuloNoBanco && existeStarterNoBanco)
            {
                var tecnologia1 = new Tecnologia{
                Nome = ".NET",
                Descricao = "C#"
                };
                var tecnologia2 = new Tecnologia{
                    Nome = "Java",
                    Descricao = "Java"
                };

                database.Tecnologias.Add(tecnologia1);
                database.Tecnologias.Add(tecnologia2);
                database.SaveChanges();

                var programaStart1 = new ProgramaStart{
                    Nome = "Turma 01",
                    DataInicial = DateTime.Today.AddDays(1),
                    DataFinal = DateTime.Today.AddMonths(3)
                };
                var programaStart2 = new ProgramaStart{
                    Nome = "Turma 02",
                    DataInicial = DateTime.Today.AddMonths(4),
                    DataFinal = DateTime.Today.AddMonths(7)
                };

                database.ProgramaStarters.Add(programaStart1);
                database.ProgramaStarters.Add(programaStart2);
                database.SaveChanges();

                var modulo1 = new Modulo{
                    Nome = "MVC - Estudo",
                    Projeto = "Projeto com base nos estudos MVC - CRUD"
                };
                var modulo2 = new Modulo{
                    Nome = "MVC - Desafio",
                    Projeto = "Projeto com base nas regras do desafio MVC"
                };

                database.Modulos.Add(modulo1);
                database.Modulos.Add(modulo2);
                database.SaveChanges();

                var starter1 = new Starter{
                    Nome = "Stefany Lopes da Silva",
                    QuatroLetras = "SYLA",
                    Tecnologia = database.Tecnologias.First(registro => registro.Nome == ".NET"),
                    ProgramaStart = database.ProgramaStarters.First(registro => registro.Nome == "Turma 01"),
                    Modulo = database.Modulos.First(registro => registro.Nome == "MVC - Estudo")
                };
                var starter2 = new Starter{
                    Nome = "Vinicius Gonçalves Martins",
                    QuatroLetras = "VSGS",
                    Tecnologia = database.Tecnologias.First(registro => registro.Nome == ".NET"),
                    ProgramaStart = database.ProgramaStarters.First(registro => registro.Nome == "Turma 01"),
                    Modulo = database.Modulos.First(registro => registro.Nome == "MVC - Estudo")
                };
                var starter3 = new Starter{
                    Nome = "Guilherme Garcia de Oliveira Vaz",
                    QuatroLetras = "GEGZ",
                    Tecnologia = database.Tecnologias.First(registro => registro.Nome == "Java"),
                    ProgramaStart = database.ProgramaStarters.First(registro => registro.Nome == "Turma 02"),
                    Modulo = database.Modulos.First(registro => registro.Nome == "MVC - Desafio")
                };
                var starter4 = new Starter{
                    Nome = "Gillian Oliveira Gomes",
                    QuatroLetras = "GNOS",
                    Tecnologia = database.Tecnologias.First(registro => registro.Nome == "Java"),
                    ProgramaStart = database.ProgramaStarters.First(registro => registro.Nome == "Turma 02"),
                    Modulo = database.Modulos.First(registro => registro.Nome == "MVC - Desafio")
                };

                database.Starters.Add(starter1);
                database.Starters.Add(starter2);
                database.Starters.Add(starter3);
                database.Starters.Add(starter4);
                database.SaveChanges();

                var grupo1 = new Grupo{
                    ScrumMaster = "Clécio Gomes Rocha da Silva",
                    Tecnologia = database.Tecnologias.First(registro => registro.Nome == ".NET"),
                };
                var grupo2 = new Grupo{
                    ScrumMaster = "David Augusto Marcelino Veiga",
                    Tecnologia = database.Tecnologias.First(registro => registro.Nome == "Java"),
                };

                database.Grupos.Add(grupo1);
                database.Grupos.Add(grupo2);
                database.SaveChanges();

                starter1.Grupo = grupo1;
                starter2.Grupo = grupo1;
                starter3.Grupo = grupo2;
                starter4.Grupo = grupo2;
                database.Update(starter1);
                database.Update(starter2);
                database.Update(starter3);
                database.Update(starter4);

                var daily1 = new Daily{
                    Data = DateTime.Today.AddDays(1),
                    Fazendo = "Fazendo os CRUD's da aplicação",
                    Feito = "As migrations",
                    Impedimentos = "Sem impedimentos",
                    Presenca = 2,
                    Grupo = database.Grupos.First(registro => registro.ScrumMaster == "Clécio Gomes Rocha da Silva"),
                    Modulo = database.Modulos.First(registro => registro.Nome == "MVC - Estudo"),
                    Starter = database.Starters.First(registro => registro.Nome == "Stefany Lopes da Silva")
                };
                var daily2 = new Daily{
                    Data = DateTime.Today.AddDays(1),
                    Fazendo = "Fazendo as entidades da aplicação",
                    Feito = "O UML para definir os relacionamentos",
                    Impedimentos = "Sem impedimentos",
                    Presenca = 2,
                    Grupo = database.Grupos.First(registro => registro.ScrumMaster == "Clécio Gomes Rocha da Silva"),
                    Modulo = database.Modulos.First(registro => registro.Nome == "MVC - Estudo"),
                    Starter = database.Starters.First(registro => registro.Nome == "Vinicius Gonçalves Martins")
                };

                database.Dailys.Add(daily1);
                database.Dailys.Add(daily2);
                database.SaveChanges();

                var projeto1 = new Projeto{
                    Avaliacao = "Exceeds expectations",
                    Modulo = database.Modulos.First(registro => registro.Nome == "MVC - Estudo"),
                    Starter = database.Starters.First(registro => registro.Nome == "Vinicius Gonçalves Martins")
                };
                var projeto2 = new Projeto{
                    Avaliacao = "Meet expectations",
                    Modulo = database.Modulos.First(registro => registro.Nome == "MVC - Desafio"),
                    Starter = database.Starters.First(registro => registro.Nome == "Guilherme Garcia de Oliveira Vaz")
                };

                database.Projetos.Add(projeto1);
                database.Projetos.Add(projeto2);
                database.SaveChanges();

                return View("../Home/Index");
            }
            else
            {
                return View("../Home/Index");
            }
        }
    }
}