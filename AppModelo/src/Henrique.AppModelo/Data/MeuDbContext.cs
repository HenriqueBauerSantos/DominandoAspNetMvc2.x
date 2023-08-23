using Henrique.AppModelo.Models;
using Microsoft.EntityFrameworkCore;

namespace Henrique.AppModelo.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
