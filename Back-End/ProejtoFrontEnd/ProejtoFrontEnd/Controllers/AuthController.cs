using Microsoft.AspNetCore.Mvc;
using ProejtoFrontEnd.Services.Interfaces;
using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using System.Net;

namespace ProejtoFrontEnd.Controllers
{
    [ApiController]
    [Route("Auth")]
    public class AuthController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        public AuthController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("Registrar")]
        public async Task<IActionResult> Registrar(Usuario usuario)
        {
            var resposta = new Respostas<UsuarioDTO>();

            var listaResult = new List<UsuarioDTO>();

            try
            {
                var criarCliente = await _usuarioService.PostUsuario(usuario);

                if(criarCliente.Login != null)
                {
                    listaResult.Add(criarCliente);

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
    }
}
