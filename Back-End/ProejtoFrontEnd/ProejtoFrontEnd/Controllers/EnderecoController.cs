using Microsoft.AspNetCore.Mvc;
using ProejtoFrontEnd.Services.Interfaces;
using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using System.Net;

namespace ProejtoFrontEnd.Controllers
{
    [ApiController]
    [Route("Endereco")]
    public class EnderecoController : Controller
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost("CadastrarEndereco")]
        public async Task<IActionResult> CadastrarEndereco(Endereco endereco)
        {
            var resposta = new Resposta<EnderecoDTO>();

            var listaResult = new List<EnderecoDTO>();

            try
            {
                var cadastrarEndereco = await _enderecoService.PostEndereco(endereco);

                if(cadastrarEndereco != null)
                {
                    listaResult.Add(cadastrarEndereco);

                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.Created;
                    resposta.Data = listaResult;
                    resposta.Message = $"Endereco Registrado Com Sucesso";
                }
                else
                {
                    resposta.Success = false;
                    resposta.StatusCode = HttpStatusCode.NoContent;
                    resposta.Data = listaResult;
                    resposta.Message = "Endereco Não Foi Cadastrado";
                }

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadGateway;
                resposta.Data = listaResult;
                resposta.Message = $"Falha ao cadastrar endeereco. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }
    }
}
