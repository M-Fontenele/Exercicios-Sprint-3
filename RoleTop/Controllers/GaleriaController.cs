using Microsoft.AspNetCore.Mvc;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class GaleriaController : AbstractController
    {
        public IActionResult Plantas()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Plantas",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Salao()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Salao",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        
        public IActionResult Casamento()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Casamento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Balada()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Balada",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Formatura()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Formatura",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult OutrosEventos()
        {
            return View(new BaseViewModel()
            {
                NomeView = "OutrosEventos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}