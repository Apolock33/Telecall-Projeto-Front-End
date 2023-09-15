using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Models.Context;
using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoFrontEnd_BackEnd.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private readonly AppDbContext _db;
        public UsuarioRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> SearchLogin(string logIn)
        {
            var getUser = _db.Usuarios.Find(logIn);

            if (getUser == null)
            {
                return Task.FromResult(false);
            }
            else
            {
                return Task.FromResult(true);
            }
        }

        public Task<bool> ValidatePassword(string password)
        {
            var getUser = _db.Usuarios.Where(p=>p.Senha == password);

            if (getUser == null)
            {
                return Task.FromResult(false);
            }
            else
            {
                return Task.FromResult(true);
            }
        }
    }
}
