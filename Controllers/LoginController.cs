using Microsoft.AspNetCore.Mvc;

namespace SistemaLogin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
