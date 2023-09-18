using ProejtoFrontEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Models.Context;

namespace ProejtoFrontEnd.Repositories
{
    public class ClientesRepository : Repository<Cliente>, IClientesRepository
    {
        public ClientesRepository(AppDbContext db) : base(db)
        {
        }
    }
}
