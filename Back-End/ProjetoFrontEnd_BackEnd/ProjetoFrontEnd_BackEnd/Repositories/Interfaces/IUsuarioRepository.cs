using ProjetoFrontEnd_BackEnd.Models;

namespace ProjetoFrontEnd_BackEnd.Repositories.Interfaces
{
    public interface IUsuarioRepository: IRepository<Usuario>
    {
        Task<bool> SearchLogin(string logIn);
        Task<bool> ValidatePassword(string password);
    }
}
