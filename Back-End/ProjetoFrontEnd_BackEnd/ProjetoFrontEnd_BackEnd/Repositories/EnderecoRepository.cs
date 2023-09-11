using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Models.Context;
using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoFrontEnd_BackEnd.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext db) : base(db)
        {
        }
    }
}
