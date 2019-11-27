using Microsoft.AspNetCore.Mvc;

namespace RoleTop.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Login()
        {
            ViewData["NomeView"] = "Cliente";
            return View();
        }
    }
}