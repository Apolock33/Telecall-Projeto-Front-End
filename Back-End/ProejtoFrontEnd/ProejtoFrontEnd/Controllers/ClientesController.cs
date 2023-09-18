using Microsoft.AspNetCore.Mvc;
using ProejtoFrontEnd.Services.Interfaces;
using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using System.Net;

namespace ProejtoFrontEnd.Controllers
{
    [ApiController]
    [Route("Clientes")]
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;
        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost("CriarCliente")]
        public async Task<IActionResult> CriarCliente(Cliente cliente)
        {
            var resposta = new Respostas<ClienteDTO>();

            var lista = new List<ClienteDTO>();

            try
            {
                var create = await _clienteService.PostCliente(cliente);

                if (create.Documento != null)
                {
                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.Created;
                    resposta.Data = lista;
                    resposta.Message = "Cliente Cadastrado Com Sucesso!";
                }

                lista.Add(create);

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = lista;
                resposta.Message = $"Falha ao criar cliente. Detalhamento de erro: {ex.Message}";
                return BadRequest(resposta);
            }
        }

        [HttpGet("ListarClientes")]
        public async Task<IActionResult> GetAllClientes()
        {
            var resposta = new Respostas<ClienteDTO>();

            try
            {
                var listarClientes = await _clienteService.GetAllClientes();

                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = listarClientes.ToList();
                resposta.Message = "Lista Recuperada";

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = new List<ClienteDTO>();
                resposta.Message = $"Falha ao recuperar lista de clientes. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpGet("ObterClienteById")]
        public async Task<IActionResult> ObterClienteById(Guid id)
        {
            var resposta = new Respostas<ClienteDTO>();

            try
            {
                var getById = await _clienteService.GetCliente(id);

                if(getById == null)
                {

                    resposta.Message = "Cliente Não Encontrado";
                }
                else
                {
                    resposta.Message = "Cliente Encontrado";
                }

                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = getById.ToList();

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = new List<ClienteDTO>();
                resposta.Message = $"Erro ao encontrar cliente. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpPut("AtualizarCliente")]
        public async Task<IActionResult> AtualizarCliente(Cliente cliente)
        {
            var resposta = new Respostas<ClienteDTO>();

            var lista = new List<ClienteDTO>();

            try
            {
                var update = await _clienteService.PutCliente(cliente);

                if (update.Documento != null)
                {
                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Data = lista;
                    resposta.Message = "Cliente Atualizado Com Sucesso!";
                }

                lista.Add(update);

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = lista;
                resposta.Message = $"Falha ao atualizar cliente. Detalhamento de erro: {ex.Message}";
                return BadRequest(resposta);
            }
        }

        [HttpDelete("DeletarCliente")]
        public async Task<IActionResult> DeletarCliente(Guid id)
        {
            var resposta = new Respostas<ClienteDTO>();

            try
            {
                var deleteCliente = await _clienteService.DeleteCliente(id);

                if (deleteCliente)
                {
                    resposta.Success = true;
                    resposta.Data = new List<ClienteDTO>();
                    resposta.StatusCode = HttpStatusCode.Accepted;
                    resposta.Message = "Cliente Deletado Com Sucesso";
                }

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.Data = new List<ClienteDTO>();
                resposta.StatusCode = HttpStatusCode.Accepted;
                resposta.Message = $"Falha ao deletar ciente. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }
    }
}
