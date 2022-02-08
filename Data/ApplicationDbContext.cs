using System;
using System.Collections.Generic;
using System.Text;
using ControleStarter.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ControleStarter.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Daily> Dailys { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<ProgramaStart> ProgramaStarters { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Starter> Starters { get; set; }
        public DbSet<Tecnologia> Tecnologias { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
