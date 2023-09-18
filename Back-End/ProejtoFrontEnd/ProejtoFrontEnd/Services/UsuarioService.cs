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

        public async Task<UsuarioDTO> PostUsuario(Usuario usuario)
        {
            var usuarioDto = new UsuarioDTO();

            var usuarioExiste = await _usuarioRepository.Find(u => u.Login == usuario.Login);

            if (!usuarioExiste.Any())
            {
                usuario.UsuarioId = Guid.NewGuid();
                usuario.Tipo = 1;
                usuario.CriadoEm = DateTime.UtcNow;
                usuario.CodigoDeValidacao = GerarCodigoDeValidacao();

                var postUsuario = await _usuarioRepository.Add(usuario);

                usuarioDto.UsuarioId = usuario.UsuarioId;
                usuarioDto.Nome = usuario.Nome;
                usuarioDto.Sexo = usuario.Sexo;
                usuarioDto.Documento = usuario.Documento;
                usuarioDto.Celular = usuario.Celular;
                usuarioDto.Fixo = usuario.Fixo;
                usuarioDto.NomeMaterno = usuario.NomeMaterno;
                usuarioDto.DataNascimento = usuario.DataNascimento;
                usuarioDto.Login = usuario.Login;
                usuarioDto.Senha = usuario.Senha;
                usuarioDto.Tipo = usuario.Tipo;
                usuarioDto.CodigoDeValidacao = usuario.CodigoDeValidacao;
                usuarioDto.CriadoEm = usuario.CriadoEm;
            }

            return usuarioDto;
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

                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.Accepted;
                    resposta.Token = token.ToString();
                    resposta.Message = "Token Gerado Com Sucesso";
                }
                else
                {
                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.BadRequest;
                    resposta.Token = "";
                    resposta.Message = "Falha ao gerar token!";
                }

                return resposta;
            }
            else
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Token = "";
                resposta.Message = "Falha ao gerar token!";

                return resposta;
            }
        }
    }
}
