using ProjetoModuloFrontEnd_BackEnd.Models;
using ProjetoModuloFrontEnd_BackEnd.Models.Context;
using ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoModuloFrontEnd_BackEnd.Repositories
{
    public class LinhasRepository : Repository<Linhas>, ILinhasRepository
    {
        public LinhasRepository(AppDbContext db) : base(db)
        {
        }
    }
}
