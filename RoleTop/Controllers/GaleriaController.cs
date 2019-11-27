using Microsoft.AspNetCore.Mvc;

namespace RoleTop.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Plantas()
        {
            ViewData["NomeView"] = "Galeria";
            return View();
        }

        public IActionResult Salao()
        {
            ViewData["NomeView"] = "Salao";
            return View();
        }
        
        public IActionResult Casamento()
        {
            ViewData["NomeView"] = "Casamento";
            return View();
        }
        public IActionResult Balada()
        {
            ViewData["NomeView"] = "Balada";
            return View();
        }
        public IActionResult Formatura()
        {
            ViewData["NomeView"] = "Formatura";
            return View();
        }
        public IActionResult OutrosEventos()
        {
            ViewData["NomeView"] = "OutrosEventos";
            return View();
        }
    }
}