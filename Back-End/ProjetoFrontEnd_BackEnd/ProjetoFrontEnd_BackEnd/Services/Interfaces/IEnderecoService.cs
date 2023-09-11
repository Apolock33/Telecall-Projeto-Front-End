using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;

namespace ProjetoFrontEnd_BackEnd.Services.Interfaces
{
    public interface IEnderecoService
    {
        Task<EnderecoDTO> Create(Endereco endereco);
        Task<IEnumerable<EnderecoDTO>> GetAll();
        Task<EnderecoDTO> GetById(Guid id);
        Task<EnderecoDTO> Verify(Endereco endereco);
        Task<EnderecoDTO> Update(Endereco endereco);
        Task<bool> Delete(Guid id);
    }
}
