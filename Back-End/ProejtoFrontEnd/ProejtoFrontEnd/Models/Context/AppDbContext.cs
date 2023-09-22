using Microsoft.EntityFrameworkCore;
using ProejtoFrontEnd.Models;

namespace ProjetoFrontEnd_BackEnd.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
