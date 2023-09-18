using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;

namespace ProejtoFrontEnd.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioDTO> PostUsuario(Usuario usuario);
        Task<RespostaUsuario> LogIn(string logIn, string senha);
        string GerarCodigoDeValidacao();
    }
}
