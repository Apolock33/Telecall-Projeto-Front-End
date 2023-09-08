using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Models.Context;
using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoFrontEnd_BackEnd.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(AppDbContext db) : base(db)
        {
        }
    }
}
