using ProejtoFrontEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Models.Context;

namespace ProejtoFrontEnd.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext db) : base(db)
        {
        }
    }
}
