using ProjetoModuloFrontEnd_BackEnd.Models;
using ProjetoModuloFrontEnd_BackEnd.Models.Context;
using ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoModuloFrontEnd_BackEnd.Repositories
{
    public class CosntasRepository : Repository<Contas>, IContasRepository
    {
        public ContasRepository(AppDbContext db) : base(db)
        {
        }
    }
}
