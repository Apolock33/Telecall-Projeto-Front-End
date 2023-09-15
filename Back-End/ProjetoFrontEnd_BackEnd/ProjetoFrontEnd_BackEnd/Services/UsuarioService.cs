using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.Services.Interfaces;
using System.Linq.Expressions;

namespace ProjetoFrontEnd_BackEnd.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public UsuarioService(IEnderecoRepository enderecoRepository, IUsuarioRepository usuarioRepository)
        {
            _enderecoRepository = enderecoRepository;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioDTO> PostUsuario(Usuario usuario)
        {
            var usuarioDto = new UsuarioDTO();

            var verifyData = await _usuarioRepository.GetBy(u => u.Login == usuario.Login);

            if (verifyData.Documento != usuario.Documento && verifyData.Login != usuario.Login && verifyData == null)
            {
                usuario.UsuarioId = Guid.NewGuid();
                usuario.CriadoEm = DateTime.UtcNow; // se estourar erro, rever essa linha
                var postUsuario = _usuarioRepository.Post(usuario);

                usuarioDto.UsuarioId = usuario.UsuarioId;
                usuarioDto.Nome = usuario.Nome;
                usuarioDto.Documento = usuario.Documento;
                usuarioDto.Sexo = usuario.Sexo;
                usuarioDto.Celular = usuario.Celular;
                usuarioDto.Fixo = usuario.Fixo;
                usuarioDto.DataNascimento = usuario.DataNascimento;
                usuarioDto.NomeMaterno = usuario.NomeMaterno;
                usuarioDto.Login = usuario.Login;
                usuarioDto.CriadoEm = usuario.CriadoEm;

                if (usuario.Endereco != null)
                {
                    usuario.Endereco.EnderecoId = Guid.NewGuid();
                    usuario.Endereco.UsuarioId = usuario.UsuarioId;
                    var postEndereco = _enderecoRepository.Post(usuario.Endereco);

                    usuarioDto.Endereco = usuario.Endereco;
                }
            }

            return usuarioDto;
        }

        public async Task<UsuarioDTO> GetUsuario(Guid id)
        {
            var usuarioDto = new UsuarioDTO();

            var getUsuarioById = await _usuarioRepository.GetBy(u=>u.UsuarioId == id);

            usuarioDto.UsuarioId = getUsuarioById.UsuarioId;
            usuarioDto.Nome = getUsuarioById.Nome;
            usuarioDto.Documento = getUsuarioById.Documento;
            usuarioDto.Sexo = getUsuarioById.Sexo;
            usuarioDto.Celular = getUsuarioById.Celular;
            usuarioDto.Fixo = getUsuarioById.Fixo;
            usuarioDto.DataNascimento = getUsuarioById.DataNascimento;
            usuarioDto.NomeMaterno = getUsuarioById.NomeMaterno;
            usuarioDto.Login = getUsuarioById.Login;
            usuarioDto.Endereco = getUsuarioById.Endereco;
            usuarioDto.CriadoEm = getUsuarioById.CriadoEm;

            return usuarioDto;
        }

        public async Task<IEnumerable<UsuarioDTO>> ListUsuarios()
        {
            var usuarioDto = new UsuarioDTO();

            var listaUsuariosDto = new List<UsuarioDTO>();

            var getAllUsuarios = await _usuarioRepository.GetAll();

            foreach(var usuario in getAllUsuarios.ToArray())
            {
                usuarioDto.UsuarioId = usuario.UsuarioId;
                usuarioDto.Nome = usuario.Nome;
                usuarioDto.Documento = usuario.Documento;
                usuarioDto.Sexo = usuario.Sexo;
                usuarioDto.Celular = usuario.Celular;
                usuarioDto.Fixo = usuario.Fixo;
                usuarioDto.DataNascimento = usuario.DataNascimento;
                usuarioDto.NomeMaterno = usuario.NomeMaterno;
                usuarioDto.Login = usuario.Login;
                usuarioDto.Endereco = usuario.Endereco;
                usuarioDto.CriadoEm = usuario.CriadoEm;

                listaUsuariosDto.Add(usuarioDto);
            }

            return listaUsuariosDto.AsEnumerable();
        }

        public async Task<UsuarioDTO> UpdateUsuario(Usuario usuario)
        {
            var usuarioDto = new UsuarioDTO();

            var findUsuario = await _usuarioRepository.GetBy(u=>u.UsuarioId == usuario.UsuarioId);

            if (findUsuario != null)
            {
                var updateUsuario = await _usuarioRepository.Put(usuario);

                usuarioDto.UsuarioId = usuario.UsuarioId;
                usuarioDto.Nome = usuario.Nome;
                usuarioDto.Documento = usuario.Documento;
                usuarioDto.Sexo = usuario.Sexo;
                usuarioDto.Celular = usuario.Celular;
                usuarioDto.Fixo = usuario.Fixo;
                usuarioDto.DataNascimento = usuario.DataNascimento;
                usuarioDto.NomeMaterno = usuario.NomeMaterno;
                usuarioDto.Login = usuario.Login;
                usuarioDto.Endereco = usuario.Endereco;
                usuarioDto.CriadoEm = usuario.CriadoEm;
            }

            return usuarioDto;
        }

        public async Task<UsuarioDTO> DeleteUsuario(Guid id)
        {
            var usuarioDto = new UsuarioDTO();

            var findUsuario = await _usuarioRepository.GetBy(u=>u.UsuarioId == id);

            if(findUsuario != null)
            {
                if(findUsuario.Endereco != null)
                {
                    var deleteEndereco = await _enderecoRepository.Delete(findUsuario.Endereco.EnderecoId);
                    usuarioDto.Endereco = findUsuario.Endereco;
                }
                
                var deleteUsuario = await _usuarioRepository.Delete(id);

                usuarioDto.UsuarioId = findUsuario.UsuarioId;
                usuarioDto.Nome = findUsuario.Nome;
                usuarioDto.Documento = findUsuario.Documento;
                usuarioDto.Sexo = findUsuario.Sexo;
                usuarioDto.Celular = findUsuario.Celular;
                usuarioDto.Fixo = findUsuario.Fixo;
                usuarioDto.DataNascimento = findUsuario.DataNascimento;
                usuarioDto.NomeMaterno = findUsuario.NomeMaterno;
                usuarioDto.Login = findUsuario.Login;       
                usuarioDto.CriadoEm = findUsuario.CriadoEm;
            }

            return usuarioDto;
        }

        public async Task<bool> ValidarUsuario(string logIn, string senha)
        {
            var getLogIn = await _usuarioRepository.SearchLogin(logIn);
            var getPassword = await _usuarioRepository.ValidatePassword(logIn);

            if (getLogIn && getPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
