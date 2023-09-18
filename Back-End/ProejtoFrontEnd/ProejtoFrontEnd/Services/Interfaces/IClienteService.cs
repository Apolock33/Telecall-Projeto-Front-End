using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;

namespace ProejtoFrontEnd.Services.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDTO> PostCliente(Cliente cliente);
        Task<IEnumerable<ClienteDTO>> GetAllClientes();
        Task<IEnumerable<ClienteDTO>> GetCliente(Guid id);
        Task<ClienteDTO> PutCliente(Cliente cliente);
        Task<bool> DeleteCliente(Guid id);
    }
}
