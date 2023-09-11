using Microsoft.AspNetCore.Mvc;
using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Services.Interfaces;
using System.Net;

namespace ProjetoFrontEnd_BackEnd.Controllers
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
            var resposta = new Resposta<ClienteDTO>();

            var clientedto = new ClienteDTO();
            try
            {
                var verify = await _clienteService.Verify(cliente);

                if (verify == null)
                {
                    cliente.ClienteId = Guid.NewGuid();
                    clientedto.ClienteId = cliente.ClienteId;
                    clientedto.Nome = cliente.Nome;
                    clientedto.Email = cliente.Email;
                    clientedto.Documento = cliente.Documento;
                    clientedto.Phone = cliente.Phone;

                    var postCliente = await _clienteService.Create(cliente);

                    if(postCliente != null)
                    {
                        resposta.Success = true;
                        resposta.StatusCode = HttpStatusCode.Created;
                        resposta.Data = clientedto;
                        resposta.Message = "Cliente Cadastrado";
                    }

                    return Ok(resposta);
                }
                else
                {
                    resposta.Success = false;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Message = "Email já existente";

                    return Ok(resposta);
                }
            }
            catch (NullReferenceException ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = clientedto;
                resposta.Message = $"Formulário nulo. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpGet("ListarClientes")]
        public async Task<IActionResult> ListarClientes()
        {
            var resposta = new Resposta<ClienteDTO>();

            try
            {
                var listAllClientes = await _clienteService.GetAll();

                if (listAllClientes == null)
                {
                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Message = $"Nenhum cliente encontrado";

                    return Ok(resposta);
                }
                else
                {
                    return Ok(listAllClientes);
                }
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Message = $"Erro ao capturar lista de Clientes. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpGet("ObterClientePorId")]
        public async Task<IActionResult> ObterClientePorId(Guid id)
        {
            var resposta = new Resposta<ClienteDTO>();

            var clientedto = new ClienteDTO();

            try
            {
                var getClientes = await _clienteService.GetById(id);

                if (getClientes == null)
                {
                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Message = $"Nenhum cliente encontrado";

                    return Ok(resposta);
                }
                else
                {
                    clientedto.ClienteId = getClientes.ClienteId;
                    clientedto.Nome = getClientes.Nome;
                    clientedto.Email = getClientes.Email;
                    clientedto.Documento = getClientes.Documento;
                    clientedto.Phone = getClientes.Phone;

                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Data = clientedto;
                    resposta.Message = $"Cliente Encontrado";

                    return Ok(resposta);
                }
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Message = $"Erro ao capturar Cliente. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpPut("AtualizarCliente")]
        public async Task<IActionResult> AtualizarCliente(Cliente cliente)
        {
            var resposta = new Resposta<ClienteDTO>();

            var clientedto = new ClienteDTO();

            try
            {
                if (cliente != null)
                {
                    var putCliente = await _clienteService.Update(cliente);

                    clientedto.ClienteId = cliente.ClienteId;
                    clientedto.Nome = cliente.Nome;
                    clientedto.Email = cliente.Email;
                    clientedto.Documento = cliente.Documento;
                    clientedto.Phone = cliente.Phone;

                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.Accepted;
                    resposta.Data = clientedto;
                    resposta.Message = "Cliente Atualizado";
                }

                return Ok(resposta);

            }
            catch (NullReferenceException ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = clientedto;
                resposta.Message = $"Formulário nulo. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpDelete("DeletarCliente")]
        public async Task<IActionResult> DeleteCliente(Guid id)
        {
            var resposta = new Resposta<ClienteDTO>();

            var clientedto = new ClienteDTO();

            try
            {
                var getCliente = await _clienteService.GetById(id);

                if (getCliente != null)
                {
                    var deleteCliente = await _clienteService.Delete(id);

                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Message = $"Cliente: {getCliente.Nome}"
                        + $"Id:{getCliente.ClienteId}"
                        + "Status: Deletado.";
                }
                else
                {
                    resposta.Success = false;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Message = $"Cliente: {getCliente.Nome}"
                        + $"Id:{getCliente.ClienteId}"
                        + "Status: Não Encontrado.";
                }

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = clientedto;
                resposta.Message = $"Não Deletado. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }
    }
}
