using ProjetoModuloFrontEnd_BackEnd.Models;
using ProjetoModuloFrontEnd_BackEnd.Models.Context;
using ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoModuloFrontEnd_BackEnd.Repositories
{
    public class ClientesRepository : Repository<Clientes>, IClientesRepository
    {
        public ClientesRepository(AppDbContext db) : base(db)
        {
        }
    }
}
