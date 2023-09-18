using ProejtoFrontEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Models.Context;

namespace ProejtoFrontEnd.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private readonly AppDbContext _db;
        public UsuarioRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ValidarLogin(string logIn)
        {
            var resposta = false;

            var loginValido = _db.Usuarios.Where(u=>u.Login == logIn);

            if (loginValido != null)
            {
                resposta = true;
            }

            return Task.FromResult(resposta);
        }

        public Task<bool> ValidarSenha(string senha)
        {
            var resposta = false;

            var senhaValida = _db.Usuarios.Where(u => u.Senha == senha);

            if (senhaValida != null)
            {
                resposta = true;
            }

            return Task.FromResult(resposta);
        }
    }
}
