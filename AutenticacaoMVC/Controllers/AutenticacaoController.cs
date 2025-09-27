using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoMVC.Controllers
{
    public class AutenticacaoController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
