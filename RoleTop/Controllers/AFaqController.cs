using Microsoft.AspNetCore.Mvc;

namespace RoleTop.Controllers
{
    public class AFaqController : Controller
    {
        public IActionResult Faq()
        {
            ViewData["NomeView"] = "AFaq";
            return View();
        }
    }
}