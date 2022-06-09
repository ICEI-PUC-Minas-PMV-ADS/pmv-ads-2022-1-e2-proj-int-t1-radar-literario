using Microsoft.EntityFrameworkCore;

namespace RadarLiterario.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Arquivos> Arquivos { get; set; }
    }
}
