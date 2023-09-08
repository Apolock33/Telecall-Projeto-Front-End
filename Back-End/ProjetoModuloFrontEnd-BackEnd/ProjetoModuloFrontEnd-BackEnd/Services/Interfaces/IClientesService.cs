using Azure;
using ProjetoModuloFrontEnd_BackEnd.DTOs;
using ProjetoModuloFrontEnd_BackEnd.Models;

namespace ProjetoModuloFrontEnd_BackEnd.Services.Interfaces
{
    public interface IClientesService
    {
        Task<ClienteDTO> Create(Clientes cliente);
        Task<IEnumerable<ClienteDTO>> GetAll();
        Task<ClienteDTO> GetBy(Guid id);
        Task<ClienteDTO> Update(Clientes cliente);
        Task<Resposta<ClienteDTO>> Delete(Guid id);
    }
}
