using Microsoft.AspNetCore.Mvc;

namespace RoleTop.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Agendar()
        {
            ViewData["NomeView"] = "Agenda";
            return View();
        }
    }
}