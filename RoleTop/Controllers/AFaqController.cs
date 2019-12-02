using Microsoft.AspNetCore.Mvc;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class AFaqController : AbstractController
    {
        public IActionResult Faq()
        {
            return View(new BaseViewModel()
            {
                NomeView = "AFaq",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}