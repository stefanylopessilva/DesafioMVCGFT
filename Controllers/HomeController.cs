using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ControleStarter.Models;
using Microsoft.AspNetCore.Identity;
using ControleStarter.Data;
using System.Security.Claims;

namespace ControleStarter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext database;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, ApplicationDbContext database)
        {
            _logger = logger;
            _userManager = userManager;
            this.database = database;
        }

        public async Task<IActionResult> Index()
        {
            var adminExisteNoBanco = database.Users.Where(user => user.Email == "admin@admin.com").ToList().Count == 0;
            
            if (adminExisteNoBanco)
            {
                var usuario = new IdentityUser { UserName = "admin@admin.com", Email = "admin@admin.com", EmailConfirmed = false };
                var resultado = await _userManager.CreateAsync(usuario, "Admin2021");

                await _userManager.AddClaimAsync(usuario, new Claim("Nome", "Admin"));
                await _userManager.AddClaimAsync(usuario, new Claim("Sobrenome", "Admin"));

                if (resultado.Succeeded)
                {
                    await _userManager.AddClaimAsync(usuario, new Claim("nomeCompleto", "Administrador"));
                    await _userManager.AddClaimAsync(usuario, new Claim("nivelAcesso", "administrador"));
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
