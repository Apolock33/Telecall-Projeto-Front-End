using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using System.Linq.Expressions;

namespace ProjetoFrontEnd_BackEnd.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task<UsuarioDTO> PostUsuario(Usuario usuario);
        public Task<IEnumerable<UsuarioDTO>> ListUsuarios();
        public Task<UsuarioDTO> GetUsuario(Guid id);
        public Task<UsuarioDTO> UpdateUsuario(Usuario usuario);
        public Task<UsuarioDTO> DeleteUsuario(Guid id);
        public Task<bool> ValidarUsuario(string logIn, string senha);
    }
}
