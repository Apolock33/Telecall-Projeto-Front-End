using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProejtoFrontEnd.Services;
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
                //endereco.UsuarioId = Guid.Parse(@TempData["UsuarioId"].ToString().Replace("{", "").Replace("}", ""));

                var cadastrarEndereco = await _enderecoService.PostEndereco(endereco);

                if (cadastrarEndereco != null)
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
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = listaResult;
                resposta.Message = $"Falha ao cadastrar endeereco. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [Authorize]
        [HttpGet("ListarEnderecos")]
        public async Task<IActionResult> ListarEnderecos()
        {
            var resposta = new Resposta<EnderecoDTO>();

            try
            {
                var listarEnd = await _enderecoService.GetAllEnderecos();

                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = listarEnd.ToList();
                resposta.Message = $"Lista de Enderecos Recuperada Com Sucesso";

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = new List<EnderecoDTO>();
                resposta.Message = $"Erro ao Recuperar Lista de Enderecos. Detalhanhameto de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpGet("ObterEnderecoPorId")]
        public async Task<IActionResult> ObterEnderecoPorId(Guid id)
        {
            var resposta = new Resposta<EnderecoDTO>();

            try
            {
                var getEnd = await _enderecoService.GetEndereco(id);

                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = getEnd.ToList();
                resposta.Message = $"Enderecs Recuperado Com Sucesso";

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = new List<EnderecoDTO>();
                resposta.Message = $"Erro ao Recuperar Endereco. Detalhanhameto de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpPut("AtualizarEndereco")]
        public async Task<IActionResult> AtualizarEndereco(Endereco endereco)
        {
            var resposta = new Resposta<EnderecoDTO>();

            var listaEnd = new List<EnderecoDTO>();

            try
            {
                var atualizarEnd = await _enderecoService.PutEndereco(endereco);

                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = listaEnd.ToList();
                resposta.Message = $"Endereco Atualizado Com Sucesso";

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = new List<EnderecoDTO>();
                resposta.Message = $"Erro ao atualizar endereco. Detalhanhameto de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpDelete("DeletarEndereco")]
        public async Task<IActionResult> DeletarEndereco(Guid id)
        {
            var resposta = new Resposta<EnderecoDTO>();

            try
            {
                var deleteEndereco = await _enderecoService.DeleteEndereco(id);

                if (deleteEndereco)
                {
                    resposta.Success = true;
                    resposta.Data = new List<EnderecoDTO>();
                    resposta.StatusCode = HttpStatusCode.Accepted;
                    resposta.Message = "Endereco Deletado Com Sucesso";
                }

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.Data = new List<EnderecoDTO>();
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Message = $"Falha ao deletar endereeco. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }
    }
}
