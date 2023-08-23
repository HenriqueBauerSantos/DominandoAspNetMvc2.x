using Microsoft.AspNetCore.Mvc;

namespace Henrique.AppModelo.Modulos.Vendas.Controllers
{
    public class PedidosController : Controller
    {
        [Area("Vendas")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
