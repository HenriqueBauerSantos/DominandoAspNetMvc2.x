using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppMvc.Models;

namespace AppMvc.Data
{
    public class AppMvcContext : DbContext
    {
        public AppMvcContext (DbContextOptions<AppMvcContext> options)
            : base(options)
        {
        }

        public DbSet<AppMvc.Models.Filme> Filme { get; set; } = default!;
    }
}
