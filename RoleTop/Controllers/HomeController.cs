using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTop.Models;
using RoleTop.Repositories;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class HomeController : AbstractController
    {
        AgendaRepository AgendaRepository = new AgendaRepository();
        public IActionResult Index()
        {


            return View(new HomeViewModel(DateTime.Now){
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}
