using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProejtoFrontEnd.Models.DTOs;
using ProejtoFrontEnd.Models.Enums;
using ProejtoFrontEnd.Services;
using ProejtoFrontEnd.Services.Interfaces;
using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using System.Net;

namespace ProejtoFrontEnd.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ILogService _logService;
        public UsuarioController(IUsuarioService usuarioService, ILogService logService)
        {
            _usuarioService = usuarioService;
            _logService = logService;
        }

        [HttpPost("LogIn")]
        public async Task<IActionResult> LogIn(string login, string senha)
        {
            var resposta = new RespostaUsuario();

            var logDto = new LogDTO();

            try
            {
                var logIn = await _usuarioService.LogIn(login, senha);


                logDto.Id = Guid.NewGuid();
                logDto.UsuarioId = logIn.UsuarioId;
                logDto.TipoDeErro = (logIn.StatusCode == HttpStatusCode.Accepted) ? TipoDeErro.SucessoLogin : TipoDeErro.ErroLogin;
                logDto.Mensagem = (logIn.StatusCode == HttpStatusCode.Accepted) ? "Log In Realizado" : "Falha ao logar";
                logDto.DetalhamentoDeErro = (logIn.StatusCode == HttpStatusCode.Accepted) ? "" : "Informações de Log In Incorretas";
                logDto.CriadoEm = DateTime.Now;

                var createLog = await _logService.PostLog(logDto);

                return Ok(logIn);
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Token = "";
                resposta.Message = $"Falha ao gerar token. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpPost("Registrar")]
        public async Task<IActionResult> Registrar(UsuarioDTO usuario)
        {
            var resposta = new Resposta<UsuarioDTO>();

            var listaResult = new List<UsuarioDTO>();

            try
            {
                var criarUsuario = await _usuarioService.PostUsuario(usuario);

                if (criarUsuario.Login != null)
                {
                    listaResult.Add(criarUsuario);

                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.Created;
                    resposta.Data = listaResult;
                    resposta.Message = "Usuario Criado Com Sucesso";
                }
                else
                {
                    resposta.Success = false;
                    resposta.StatusCode = HttpStatusCode.NoContent;
                    resposta.Data = listaResult;
                    resposta.Message = "Usuario Não Foi Criado";
                }

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadGateway;
                resposta.Data = listaResult;
                resposta.Message = $"Falha ao criar usuario. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpGet("ListarUsuarios")]
        public async Task<IActionResult> ListarUsuarios()
        {
            var resposta = new Resposta<UsuarioDTO>();

            try
            {
                var listarUsuarios = await _usuarioService.GetAllUsuarios();

                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = listarUsuarios.ToList();
                resposta.Message = "Lista de Usuarios Recuperada";

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = null;
                resposta.Message = $"Erro ao Recuperar Lista de Usuarios. Detalhamento de Erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpGet("ObterUsuarioById")]
        public async Task<IActionResult> ObterUsuarioPorId(Guid id)
        {
            var resposta = new Resposta<UsuarioDTO>();

            try
            {
                var getUsuario = await _usuarioService.GetUsuario(id);

                if (getUsuario == null)
                {

                    resposta.Message = "Usuario Não Encontrado";
                }
                else
                {
                    resposta.Message = "Usuario Encontrado";
                }

                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = getUsuario.ToList();

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = new List<UsuarioDTO>();
                resposta.Message = $"Erro ao encontrar usuario. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpPut("AtualizarUsuario")]
        public async Task<IActionResult> AtualizarUsuario(UsuarioDTO usuario)
        {
            var resposta = new Resposta<UsuarioDTO>();

            var lista = new List<UsuarioDTO>();

            try
            {
                var update = await _usuarioService.PutUsuario(usuario);

                if (update.Documento != null)
                {
                    lista.Add(update);

                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Data = lista;
                    resposta.Message = "Usuario Atualizado Com Sucesso!";
                }

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = lista;
                resposta.Message = $"Falha ao atualizar usuario. Detalhamento de erro: {ex.Message}";
                return BadRequest(resposta);
            }
        }

        [HttpDelete("DeletarUsuario")]
        public async Task<IActionResult> DeletarCliente(Guid id)
        {
            var resposta = new Resposta<UsuarioDTO>();

            try
            {
                var deleteUsuario = await _usuarioService.DeleteUsuario(id);

                if (deleteUsuario)
                {
                    resposta.Success = true;
                    resposta.Data = new List<UsuarioDTO>();
                    resposta.StatusCode = HttpStatusCode.Accepted;
                    resposta.Message = "Usuario Deletado Com Sucesso";
                }

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.Data = new List<UsuarioDTO>();
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Message = $"Falha ao deletar usuario. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }
    }
}
