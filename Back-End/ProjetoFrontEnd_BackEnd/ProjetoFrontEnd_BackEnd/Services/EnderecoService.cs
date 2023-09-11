using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
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

        public Task<EnderecoDTO> Create(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EnderecoDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoDTO> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoDTO> Update(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoDTO> Verify(Endereco endereco)
        {
            throw new NotImplementedException();
        }
    }
}
