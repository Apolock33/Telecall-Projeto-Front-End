using Microsoft.AspNetCore.Http.HttpResults;
using ProjetoModuloFrontEnd_BackEnd.DTOs;
using ProjetoModuloFrontEnd_BackEnd.Models;
using ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces;
using ProjetoModuloFrontEnd_BackEnd.Services.Interfaces;
using System.Net;

namespace ProjetoModuloFrontEnd_BackEnd.Services
{
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _clientesRepository;

        public ClientesService(IClientesRepository clientesRepository)
        {
            _clientesRepository = clientesRepository;
        }

        public Task<ClienteDTO> Create(Clientes cliente)
        {
            var clientedto = new ClienteDTO();

            var verifyEmail = _clientesRepository.GetBy(c => c.Email == cliente.Email);

            if (verifyEmail == null)
            {
                var postCliente = _clientesRepository.Post(cliente);

                clientedto.Nome = cliente.Nome;
                clientedto.Email = cliente.Email;
                clientedto.Documento = cliente.Documento;
                clientedto.Phone = cliente.Phone;
                clientedto.Contas = cliente.Contas;
                clientedto.Endereco = cliente.Endereco;
            }

            return Task.FromResult(clientedto);
        }

        public Task<IEnumerable<ClienteDTO>> GetAll()
        {
            var clientedto = new ClienteDTO();

            var getClientes = _clientesRepository.GetAll();

            var listaClientes = getClientes.Result.ToList();

            var listaClienteDTO = new List<ClienteDTO>();

            for (int i = getClientes.Result.Count(); i >= getClientes.Result.Count(); i--)
            {
                clientedto.ClienteId = listaClientes[i].ClienteId;
                clientedto.Documento = listaClientes[i].Documento;
                clientedto.Email = listaClientes[i].Email;
                clientedto.Nome = listaClientes[i].Nome;
                clientedto.Phone = listaClientes[i].Phone;
                clientedto.Endereco = listaClientes[i].Endereco;
                clientedto.Contas = listaClientes[i].Contas;

                listaClienteDTO.Add(clientedto);
            }

            return Task.FromResult(listaClienteDTO.AsEnumerable());
        }

        public Task<ClienteDTO> GetBy(Guid id)
        {
            var clientedto = new ClienteDTO();

            var getCliente = _clientesRepository.GetBy(c => c.ClienteId == id);

            clientedto.ClienteId = getCliente.Result.ClienteId;
            clientedto.Nome = getCliente.Result.Nome;
            clientedto.Documento = getCliente.Result.Documento;
            clientedto.Phone = getCliente.Result.Phone;
            clientedto.Endereco = getCliente.Result.Endereco;
            clientedto.Contas = getCliente.Result.Contas;

            return Task.FromResult(clientedto);
        }

        public Task<ClienteDTO> Update(Clientes cliente)
        {
            var clientedto = new ClienteDTO();

            var updateCliente = _clientesRepository.Put(cliente);

            clientedto.ClienteId = updateCliente.Result.ClienteId;
            clientedto.Nome = updateCliente.Result.Nome;
            clientedto.Documento = updateCliente.Result.Documento;
            clientedto.Phone = updateCliente.Result.Phone;
            clientedto.Endereco = updateCliente.Result.Endereco;
            clientedto.Contas = updateCliente.Result.Contas;

            return Task.FromResult(clientedto);
        }

        public Task<Resposta<ClienteDTO>> Delete(Guid id)
        {
            var resposta = new Resposta<ClienteDTO>();

            var getCliente = _clientesRepository.GetBy(c => c.ClienteId == id);

            if(getCliente != null)
            {
                var deleteCliente = _clientesRepository.Delete(getCliente.Result);

                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.Accepted;
                resposta.Data = null;
                resposta.Message = "Cliente Deletado com sucesso!";

                return Task.FromResult(resposta);
            }
            else
            {
                resposta.Success = false;
                resposta.StatusCode = HttpStatusCode.NotFound;
                resposta.Data = null;
                resposta.Message = "Cliente Não Encontrado!";

                return Task.FromResult(resposta);
            }

        }
    }
}
