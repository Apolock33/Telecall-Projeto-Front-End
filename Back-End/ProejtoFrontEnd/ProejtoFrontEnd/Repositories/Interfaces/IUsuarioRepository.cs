using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;

namespace ProejtoFrontEnd.Repositories.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<bool> ValidarLogin(string logIn);
        Task<bool> ValidarSenha(string senha);
        Task<UsuarioDTO> RetornarEntidade(string dado);
    }
}
