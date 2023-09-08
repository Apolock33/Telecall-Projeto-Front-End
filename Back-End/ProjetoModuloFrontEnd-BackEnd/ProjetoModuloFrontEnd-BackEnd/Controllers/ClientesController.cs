using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoModuloFrontEnd_BackEnd.DTOs;
using ProjetoModuloFrontEnd_BackEnd.Models;
using ProjetoModuloFrontEnd_BackEnd.Services.Interfaces;
using System.Net;

namespace ProjetoModuloFrontEnd_BackEnd.Controllers
{
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly IClientesService _clientesService;

        public ClientesController(IClientesService clientesService)
        {
            _clientesService = clientesService;
        }

        [HttpPost("CreateCliente")]
        public async Task<IActionResult> CriateCliente(Clientes cliente)
        {
            var clientedto = new ClienteDTO();
            var resposta = new Resposta<ClienteDTO>();
            try
            {
                var getCliente = await _clientesService.GetBy(cliente.ClienteId);

                if (getCliente == null)
                {
                    var postCliente = await _clientesService.Create(cliente);

                    clientedto.ClienteId = cliente.ClienteId;
                    clientedto.Nome = cliente.Nome;
                    clientedto.Email = cliente.Email;
                    clientedto.Documento = cliente.Documento;
                    clientedto.Phone = cliente.Phone;
                    clientedto.Endereco = cliente.Endereco;
                    clientedto.Contas = cliente.Contas;

                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.Created;
                    resposta.Data = clientedto;
                    resposta.Message = "Cliente criado com sucesso";
                }
                else
                {
                    resposta.Success = false;
                    resposta.StatusCode = HttpStatusCode.Ambiguous;
                    resposta.Data = clientedto;
                    resposta.Message = "Cliente já existente";
                }

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.Created;
                resposta.Data = clientedto;
                resposta.Message = $"Erro ao criar o cliente. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }
    }
}
