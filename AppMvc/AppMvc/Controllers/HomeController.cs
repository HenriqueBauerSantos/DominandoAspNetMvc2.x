using AppMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //Filme filme = new Filme()
            //{
            //    Titulo = "oi",
            //    DataLancamento = DateTime.Now,
            //    Genero = null,
            //    Avaliacao = 10,
            //    Preco = 20000,
            //};

            //return RedirectToAction("Privacy", filme);
            return View();
        }

        public IActionResult Privacy()
        {
            //if(ModelState.IsValid)
            //{

            //}

            //foreach (var error in ModelState.Values.SelectMany( m => m.Errors))
            //{
            //    Console.WriteLine(error.ErrorMessage);
            //}

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}