using Microsoft.AspNetCore.Mvc;
using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Services;
using ProjetoFrontEnd_BackEnd.Services.Interfaces;
using System.Net;

namespace ProjetoFrontEnd_BackEnd.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        //[HttpPost("RegistrarUsuario")]
        //public async Task<IActionResult> Registrar(Usuario usuario)
        //{
        //}

        [HttpPost("LogIn")]
        public async Task<IActionResult> LogIn(string logIn, string senha)
        {
            var resposta = new RespostaUsuario();

            try
            {
                var verifyLogIn = await _usuarioService.ValidarUsuario(logIn, senha);

                if (verifyLogIn)
                {
                    var token = TokenService.GenerateToken(new Usuario());

                    resposta.Success = true;
                    resposta.Token = token.ToString();
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Message = "Login Bem Sucedido";
                }
                else
                {
                    resposta.Success = true;
                    resposta.Token = null;
                    resposta.StatusCode = HttpStatusCode.Unauthorized;
                    resposta.Message = "Conta Nao Existente";
                }

                return Ok(resposta);
            }
            catch(Exception ex) 
            {
                resposta.Success = true;
                resposta.Token = null;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Message = $"Login Mal Sucedido. Detalhamento de Erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpGet("ListarUsuarios")]
        public async Task<IActionResult> ListarUsuarios()
        {
            var usuarioDto = new UsuarioDTO();

            var listUsuarioDto = new List<UsuarioDTO>();

            var resposta = new Resposta<UsuarioDTO>();

            try
            {
                var getAllUsuarios = await _usuarioService.ListUsuarios();

                if (getAllUsuarios != null)
                {

                    foreach (var item in getAllUsuarios)
                    {
                        usuarioDto.UsuarioId = item.UsuarioId;
                        usuarioDto.Nome = item.Nome;
                        usuarioDto.Documento = item.Documento;
                        usuarioDto.Sexo = item.Sexo;
                        usuarioDto.Celular = item.Celular;
                        usuarioDto.Fixo = item.Fixo;
                        usuarioDto.DataNascimento = item.DataNascimento;
                        usuarioDto.NomeMaterno = item.NomeMaterno;
                        usuarioDto.Login = item.Login;
                        usuarioDto.CriadoEm = item.CriadoEm;

                        listUsuarioDto.Add(usuarioDto);
                    }

                    resposta.Success =true;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Data = listUsuarioDto;
                    resposta.Message = "Lista Recuperada";
                }
                else
                {
                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Data = null;
                    resposta.Message = "Nenhum Dado Recuperado";
                }

                return Ok(listUsuarioDto);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = null;
                resposta.Message = $"Erro ao Recuper Dados. Detalhamento de Erro: {ex.Message}";

                return Ok(resposta);
            }
        }
    }
}
