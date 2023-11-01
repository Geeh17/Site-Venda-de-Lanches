using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            { }

        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Lanche> lanches { get; set; }

    }
}
