using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;

namespace ProejtoFrontEnd.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioDTO> PostUsuario(UsuarioDTO usuario);
        Task<IEnumerable<UsuarioDTO>> GetAllUsuarios();
        Task<IEnumerable<UsuarioDTO>> GetUsuario(Guid id);
        Task<UsuarioDTO> PutUsuario(UsuarioDTO usuario);
        Task<bool> DeleteUsuario(Guid id);
        Task<RespostaUsuario> LogIn(string logIn, string senha);
        string GerarCodigoDeValidacao();
    }
}
