using Microsoft.EntityFrameworkCore;

namespace ProjetoModuloFrontEnd_BackEnd.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Enderecos> Endereco { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Contas> Contas { get; set; }
        public DbSet<Linhas> Linhas { get; set; }
        public DbSet<Logs> Logs { get; set; }
    }
}
