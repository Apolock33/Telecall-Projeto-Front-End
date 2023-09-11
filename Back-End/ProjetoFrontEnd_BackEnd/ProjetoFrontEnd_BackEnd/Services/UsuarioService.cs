using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Repositories;
using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.Services.Interfaces;

namespace ProjetoFrontEnd_BackEnd.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository, IEnderecoRepository enderecoRepository)
        {
            _usuarioRepository = usuarioRepository;
            _enderecoRepository = enderecoRepository;
        }

        public Task<UsuarioDTO> Create(Usuario usuario)
        {
            var usuarioDto = new UsuarioDTO();

            var verifyLogIn = _usuarioRepository.GetBy(u => u.Documento == usuario.Documento);

            if (verifyLogIn.Result == null)
            {
                var postUsuario = _usuarioRepository.Post(usuario);

                usuarioDto.Nome = postUsuario.Result.Nome;
                usuarioDto.Sexo = postUsuario.Result.Sexo;
                usuarioDto.Documento = postUsuario.Result.Documento;
                usuarioDto.Celular = postUsuario.Result.Celular;
                usuarioDto.Fixo = postUsuario.Result.Fixo;
                usuarioDto.DataNascimento = postUsuario.Result.DataNascimento;
                usuarioDto.NomeMaterno = postUsuario.Result.NomeMaterno;
                usuarioDto.Login = postUsuario.Result.Login;
                usuarioDto.CriadoEm = postUsuario.Result.CriadoEm;
            }

            return Task.FromResult(usuarioDto);
        }

        public Task<IEnumerable<UsuarioDTO>> GetAll()
        {
            var usuarioDto = new UsuarioDTO();

            var getUsuarios = _usuarioRepository.GetAll();

            var listaUsuarios = getUsuarios.Result.ToList();

            var listaUsuariosDTO = new List<UsuarioDTO>();

            for (int i = listaUsuarios.Count(); i != 0; i--)
            {
                usuarioDto.UsuarioId = listaUsuarios[i - 1].UsuarioId;
                usuarioDto.Nome = listaUsuarios[i - 1].Nome;
                usuarioDto.Sexo = listaUsuarios[i - 1].Sexo;
                usuarioDto.Documento = listaUsuarios[i - 1].Documento;
                usuarioDto.Celular = listaUsuarios[i - 1].Celular;
                usuarioDto.Fixo = listaUsuarios[i - 1].Fixo;
                usuarioDto.DataNascimento = listaUsuarios[i - 1].DataNascimento;
                usuarioDto.NomeMaterno = listaUsuarios[i - 1].NomeMaterno;
                usuarioDto.Login = listaUsuarios[i - 1].Login;
                usuarioDto.CriadoEm = listaUsuarios[i - 1].CriadoEm;

                listaUsuariosDTO.Add(usuarioDto);
            }

            return Task.FromResult(listaUsuariosDTO.AsEnumerable());
        }

        public Task<UsuarioDTO> GetById(Guid id)
        {
            var usuarioDto = new UsuarioDTO();

            var getCliente = _usuarioRepository.GetBy(c => c.UsuarioId == id);

            if (getCliente != null)
            {
                usuarioDto.Nome = getCliente.Result.Nome;
                usuarioDto.Sexo = getCliente.Result.Sexo;
                usuarioDto.Documento = getCliente.Result.Documento;
                usuarioDto.Celular = getCliente.Result.Celular;
                usuarioDto.Fixo = getCliente.Result.Fixo;
                usuarioDto.DataNascimento = getCliente.Result.DataNascimento;
                usuarioDto.NomeMaterno = getCliente.Result.NomeMaterno;
                usuarioDto.Login = getCliente.Result.Login;
                usuarioDto.CriadoEm = getCliente.Result.CriadoEm;
            }

            return Task.FromResult(usuarioDto);
        }

        public Task<UsuarioDTO> Update(Usuario usuario)
        {
            var usuarioDto = new UsuarioDTO();

            var putUsuario = _usuarioRepository.Put(usuario);

            if (putUsuario.Result != null)
            {
                usuarioDto.Nome = putUsuario.Result.Nome;
                usuarioDto.Sexo = putUsuario.Result.Sexo;
                usuarioDto.Documento = putUsuario.Result.Documento;
                usuarioDto.Celular = putUsuario.Result.Celular;
                usuarioDto.Fixo = putUsuario.Result.Fixo;
                usuarioDto.DataNascimento = putUsuario.Result.DataNascimento;
                usuarioDto.NomeMaterno = putUsuario.Result.NomeMaterno;
                usuarioDto.Login = putUsuario.Result.Login;
                usuarioDto.CriadoEm = putUsuario.Result.CriadoEm;
            }

            return Task.FromResult(usuarioDto);
        }

        public Task<UsuarioDTO> Verify(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
