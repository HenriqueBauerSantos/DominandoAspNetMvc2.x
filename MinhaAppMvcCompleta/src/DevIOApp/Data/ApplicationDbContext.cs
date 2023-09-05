using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DevIOApp.ViewModels;

namespace DevIOApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DevIOApp.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; } = default!;
        public DbSet<DevIOApp.ViewModels.EnderecoViewModel> EnderecoViewModel { get; set; } = default!;
    }
}