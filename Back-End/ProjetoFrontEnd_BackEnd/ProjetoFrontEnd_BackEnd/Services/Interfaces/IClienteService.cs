using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;

namespace ProjetoFrontEnd_BackEnd.Services.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDTO> Create(Cliente cliente);
        Task<IEnumerable<ClienteDTO>> GetAll();
        Task<ClienteDTO> GetById(Guid id);
        Task<ClienteDTO> Update(Cliente cliente);
        Task<bool> Delete(Guid id);
    }
}
