using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;

namespace ProjetoFrontEnd_BackEnd.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioDTO> Create(Usuario usuario);
        Task<IEnumerable<UsuarioDTO>> GetAll();
        Task<UsuarioDTO> GetById(Guid id);
        Task<UsuarioDTO> Verify(Usuario usuario);
        Task<UsuarioDTO> Update(Usuario usuario);
        Task<bool> Delete(Guid id);
    }
}
