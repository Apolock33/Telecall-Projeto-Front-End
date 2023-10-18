using Microsoft.AspNetCore.Http.HttpResults;
using ProejtoFrontEnd.Repositories.Interfaces;
using ProejtoFrontEnd.Services.Interfaces;
using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using System.Net;

namespace ProejtoFrontEnd.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioDTO> PostUsuario(UsuarioDTO usuario)
        {
            var usuarioDto = new UsuarioDTO();

            var usuarioEntity = new Usuario();

            var usuarioExiste = await _usuarioRepository.Find(u => u.Login == usuario.Login);

            if (!usuarioExiste.Any())
            {
                usuario.UsuarioId = Guid.NewGuid();
                usuario.CriadoEm = DateTime.UtcNow;
                usuario.CodigoDeValidacao = GerarCodigoDeValidacao();

                usuarioEntity.UsuarioId = usuario.UsuarioId;
                usuarioEntity.Nome = usuario.Nome;
                usuarioEntity.Sexo = usuario.Sexo;
                usuarioEntity.Documento = usuario.Documento;
                usuarioEntity.Celular = usuario.Celular;
                usuarioEntity.Fixo = usuario.Fixo;
                usuarioEntity.NomeMaterno = usuario.NomeMaterno;
                usuarioEntity.DataNascimento = usuario.DataNascimento;
                usuarioEntity.Login = usuario.Login;
                usuarioEntity.Senha = usuario.Senha;
                usuarioEntity.Tipo = usuario.Tipo;
                usuarioEntity.CodigoDeValidacao = usuario.CodigoDeValidacao;
                usuarioEntity.CriadoEm = usuario.CriadoEm;
                usuarioEntity.Endereco = null;

                var postUsuario = await _usuarioRepository.Add(usuarioEntity);

                usuarioDto = usuario;
            }

            return usuarioDto;
        }

        public async Task<IEnumerable<UsuarioDTO>> GetAllUsuarios()
        {
            var usuarioDto = new UsuarioDTO();

            var lista = new List<UsuarioDTO>();

            var getUsuarios = await _usuarioRepository.GetAll();

            foreach (var item in getUsuarios)
            {
                usuarioDto.UsuarioId = item.UsuarioId;
                usuarioDto.Nome = item.Nome;
                usuarioDto.Sexo = item.Sexo;
                usuarioDto.Documento = item.Documento;
                usuarioDto.Celular = item.Celular;
                usuarioDto.Fixo = item.Fixo;
                usuarioDto.NomeMaterno = item.NomeMaterno;
                usuarioDto.DataNascimento = item.DataNascimento;
                usuarioDto.Login = item.Login;
                usuarioDto.Senha = item.Senha;
                usuarioDto.Tipo = item.Tipo;
                usuarioDto.CodigoDeValidacao = item.CodigoDeValidacao;
                usuarioDto.CriadoEm = item.CriadoEm;

                lista.Add(usuarioDto);
            }

            return lista;
        }

        public async Task<IEnumerable<UsuarioDTO>> GetUsuario(Guid id)
        {
            var usuarioDto = new UsuarioDTO();

            var lista = new List<UsuarioDTO>();

            var usuarioExiste = await _usuarioRepository.Find(u => u.UsuarioId == id);

            foreach (var item in usuarioExiste)
            {
                usuarioDto.UsuarioId = item.UsuarioId;
                usuarioDto.Nome = item.Nome;
                usuarioDto.Sexo = item.Sexo;
                usuarioDto.Documento = item.Documento;
                usuarioDto.Celular = item.Celular;
                usuarioDto.Fixo = item.Fixo;
                usuarioDto.NomeMaterno = item.NomeMaterno;
                usuarioDto.DataNascimento = item.DataNascimento;
                usuarioDto.Login = item.Login;
                usuarioDto.Senha = item.Senha;
                usuarioDto.Tipo = item.Tipo;
                usuarioDto.CodigoDeValidacao = item.CodigoDeValidacao;
                usuarioDto.CriadoEm = item.CriadoEm;

                lista.Add(usuarioDto);
            }

            return lista;
        }

        public async Task<UsuarioDTO> PutUsuario(UsuarioDTO usuario)
        {
            var usuarioDto = new UsuarioDTO();

            var usuarioExiste = await _usuarioRepository.Find(u => u.UsuarioId == usuario.UsuarioId);

            if (usuarioExiste.Any())
            {
                foreach (var item in usuarioExiste)
                {
                    item.UsuarioId = usuario.UsuarioId;
                    item.Nome = usuario.Nome;
                    item.Sexo = usuario.Sexo;
                    item.Documento = usuario.Documento;
                    item.Celular = usuario.Celular;
                    item.Fixo = usuario.Fixo;
                    item.NomeMaterno = usuario.NomeMaterno;
                    item.DataNascimento = item.DataNascimento;
                    item.Login = usuario.Login;
                    item.Senha = usuario.Senha;
                    item.Tipo = usuario.Tipo;
                    item.CodigoDeValidacao = usuario.CodigoDeValidacao;
                    item.CriadoEm = usuario.CriadoEm;

                    var atualizarUsuario = await _usuarioRepository.Update(item);

                    usuarioDto.UsuarioId = atualizarUsuario.UsuarioId;
                    usuarioDto.Nome = atualizarUsuario.Nome;
                    usuarioDto.Sexo = atualizarUsuario.Sexo;
                    usuarioDto.Documento = atualizarUsuario.Documento;
                    usuarioDto.Celular = atualizarUsuario.Celular;
                    usuarioDto.Fixo = atualizarUsuario.Fixo;
                    usuarioDto.NomeMaterno = atualizarUsuario.NomeMaterno;
                    usuarioDto.DataNascimento = atualizarUsuario.DataNascimento;
                    usuarioDto.Login = atualizarUsuario.Login;
                    usuarioDto.Senha = atualizarUsuario.Senha;
                    usuarioDto.Tipo = atualizarUsuario.Tipo;
                    usuarioDto.CodigoDeValidacao = atualizarUsuario.CodigoDeValidacao;
                    usuarioDto.CriadoEm = atualizarUsuario.CriadoEm;
                }
            }

            return usuarioDto;
        }

        public async Task<bool> DeleteUsuario(Guid id)
        {
            var resposta = false;

            var getUsuario = await _usuarioRepository.GetById(id);

            if (getUsuario != null)
            {
                var deleteUsuario = await _usuarioRepository.Delete(id);

                resposta = true;
            }

            return resposta;
        }

        public async Task<RespostaUsuario> LogIn(string logIn, string senha)
        {
            var resposta = new RespostaUsuario();

            var validarLogIn = await _usuarioRepository.ValidarLogin(logIn);

            if (validarLogIn)
            {
                var validarSenha = await _usuarioRepository.ValidarSenha(senha);

                if (validarSenha)
                {
                    var token = TokenService.GenerateToken(new Usuario());

                    var getUser = await _usuarioRepository.RetornarEntidade(logIn);

                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.Accepted;
                    resposta.Token = token.ToString();
                    resposta.Message = "Token Gerado Com Sucesso";
                    resposta.UsuarioId = getUser.UsuarioId;
                }
                else
                {
                    resposta.Success = false;
                    resposta.StatusCode = HttpStatusCode.BadRequest;
                    resposta.Token = "";
                    resposta.Message = "Falha ao gerar token!";
                }

                return resposta;
            }
            else
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Token = "";
                resposta.Message = "Falha ao gerar token!";

                return resposta;
            }
        }

        public string GerarCodigoDeValidacao()
        {
            int length = 6;

            var random = new Random();

            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            string codigoDeValidacao = "";

            for (int i = 0; i < length; i++)
            {
                var index = random.Next(chars.Length);
                codigoDeValidacao += chars[index];
            }

            return codigoDeValidacao.ToUpper();
        }
    }
}
