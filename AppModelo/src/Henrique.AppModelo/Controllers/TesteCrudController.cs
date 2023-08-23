using Henrique.AppModelo.Data;
using Henrique.AppModelo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Henrique.AppModelo.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Eduardo",
                DataNascimento = DateTime.Now,
                Email = "teste@jose.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);

            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == "teste@jose.com");

            aluno.Nome = "Joao";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);

            return View("_Layout");
        }
    }
}
