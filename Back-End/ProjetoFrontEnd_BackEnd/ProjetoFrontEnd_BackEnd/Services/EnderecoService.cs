using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.Services.Interfaces;

namespace ProjetoFrontEnd_BackEnd.Services
{
    public class EnderecoService: IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
    }
}
