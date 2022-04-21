using Microsoft.AspNetCore.Mvc;

namespace SistemaLogin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(string username, string senha) { 
        
            return Json(new{});
        }
    }
}
