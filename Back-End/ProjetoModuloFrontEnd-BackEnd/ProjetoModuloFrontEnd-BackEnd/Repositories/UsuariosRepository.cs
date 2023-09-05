using ProjetoModuloFrontEnd_BackEnd.Models;
using ProjetoModuloFrontEnd_BackEnd.Models.Context;
using ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoModuloFrontEnd_BackEnd.Repositories
{
    public class UsuariosRepository : Repository<Usuarios>, IUsuariosRepository
    {
        public UsuariosRepository(AppDbContext db) : base(db)
        {
        }
    }
}
