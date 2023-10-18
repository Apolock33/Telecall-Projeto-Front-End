using ProjetoFrontEnd_BackEnd.DTOs;

namespace ProejtoFrontEnd.Services.Interfaces
{
    public interface IEnderecoService
    {
        Task<EnderecoDTO> PostEndereco(EnderecoDTO endereco);
        Task<IEnumerable<EnderecoDTO>> GetAllEnderecos();
        Task<IEnumerable<EnderecoDTO>> GetEndereco(Guid id);
        Task<EnderecoDTO> PutEndereco(EnderecoDTO endereco);
        Task<bool> DeleteEndereco(Guid id);
    }
}
