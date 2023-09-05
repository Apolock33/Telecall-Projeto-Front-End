using ProjetoModuloFrontEnd_BackEnd.Models;
using ProjetoModuloFrontEnd_BackEnd.Models.Context;
using ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoModuloFrontEnd_BackEnd.Repositories
{
    public class EnderecosReposiory : Repository<Enderecos>, IEnderecosRepository
    {
        public EnderecosReposiory(AppDbContext db) : base(db)
        {
        }
    }
}
