using Microsoft.EntityFrameworkCore;
using Formulario.Models;


namespace Formulario.Data
{
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<FormularioEntity> Formulario { get; set; }
        }
}


