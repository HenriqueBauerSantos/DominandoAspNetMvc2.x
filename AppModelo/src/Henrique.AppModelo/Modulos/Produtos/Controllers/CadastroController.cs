using Microsoft.AspNetCore.Mvc;

namespace Henrique.AppModelo.Modulos.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class CadastroController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }

        [Route("produtos/busca")]
        public IActionResult Busca()
        {
            return View();
        }
    }
}
