using ProjetoModuloFrontEnd_BackEnd.Models;
using ProjetoModuloFrontEnd_BackEnd.Models.Context;
using ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoModuloFrontEnd_BackEnd.Repositories
{
    public class EnderecosRepository : Repository<Enderecos>, IEnderecosRepository
    {
        public EnderecosRepository(AppDbContext db) : base(db)
        {
        }
    }
}
