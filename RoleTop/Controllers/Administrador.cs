using Microsoft.AspNetCore.Mvc;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class Administrador : AbstractController
    {
        public IActionResult Dashboard()
        {
            return View(new RespostaViewModel()
            {

                NomeView = "Admin",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}