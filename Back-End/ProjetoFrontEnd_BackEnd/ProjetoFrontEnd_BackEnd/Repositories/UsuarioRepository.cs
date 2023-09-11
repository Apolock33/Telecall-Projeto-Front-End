using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Models.Context;
using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoFrontEnd_BackEnd.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext db) : base(db)
        {
        }
    }
}
