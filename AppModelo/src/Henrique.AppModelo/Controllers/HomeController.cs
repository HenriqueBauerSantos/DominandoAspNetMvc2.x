using Henrique.AppModelo.Data;
using Microsoft.AspNetCore.Mvc;

namespace Henrique.AppModelo.Controllers
{
    public class HomeController : Controller
    {
        private IPedidoRepository _pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IActionResult Index()
        {
            var pedido = _pedidoRepository.ObterPedido();

            return View();
        }
    }
}
