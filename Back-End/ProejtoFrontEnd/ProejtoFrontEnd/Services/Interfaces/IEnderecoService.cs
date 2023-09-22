using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;

namespace ProejtoFrontEnd.Services.Interfaces
{
    public interface IEnderecoService
    {
        Task<EnderecoDTO> PostEndereco(Endereco endereco);
        //Task<IEnumerable<EnderecoDTO>> GetAllEnderecos();
        //Task<IEnumerable<EnderecoDTO>> GetEndereco(Guid id);
        //Task<EnderecoDTO> PutEndereco(Endereco endereco);
        //Task<bool> DeleteEndereco(Guid id);
    }
}
