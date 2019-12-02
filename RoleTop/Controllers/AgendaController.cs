using Microsoft.AspNetCore.Mvc;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class AgendaController : AbstractController
    {
        public IActionResult Agendar()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Agenda",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}