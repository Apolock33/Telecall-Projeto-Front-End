using ProejtoFrontEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.DTOs;
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

        public Task<UsuarioDTO> RetornarEntidade(string dado)
        {
            var returnDto = new UsuarioDTO();

            var returnEntity = _db.Usuarios.Where(u => u.Login == dado || u.Nome == dado || u.Documento == dado).FirstOrDefault();

            returnDto.UsuarioId = returnEntity.UsuarioId;
            returnDto.Nome = returnEntity.Nome;
            returnDto.Sexo = returnEntity.Sexo;
            returnDto.Documento = returnEntity.Documento;
            returnDto.Celular = returnEntity.Celular;
            returnDto.Fixo = returnEntity.Fixo;
            returnDto.NomeMaterno = returnEntity.NomeMaterno;
            returnDto.DataNascimento = returnEntity.DataNascimento;
            returnDto.Login = returnEntity.Login;
            returnDto.Senha = returnEntity.Senha;
            returnDto.Tipo = returnEntity.Tipo;
            returnDto.CodigoDeValidacao = returnEntity.CodigoDeValidacao;
            returnDto.CriadoEm = returnEntity.CriadoEm;

            return Task.FromResult(returnDto);
        }

        public Task<bool> ValidarLogin(string logIn)
        {
            var resposta = false;

            var loginValido = _db.Usuarios.Where(u=>u.Login == logIn).FirstOrDefault();

            if (loginValido != null)
            {
                resposta = true;
            }

            return Task.FromResult(resposta);
        }

        public Task<bool> ValidarSenha(string senha)
        {
            var resposta = false;

            var senhaValida = _db.Usuarios.Where(u => u.Senha == senha).FirstOrDefault();

            if (senhaValida!= null)
            {
                resposta = true;
            }

            return Task.FromResult(resposta);
        }
    }
}
