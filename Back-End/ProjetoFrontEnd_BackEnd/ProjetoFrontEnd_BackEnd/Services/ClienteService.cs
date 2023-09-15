using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Repositories;
using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.Services.Interfaces;
using System.Linq.Expressions;
using System.Net;

namespace ProjetoFrontEnd_BackEnd.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<ClienteDTO> Create(Cliente cliente)
        {
            var clientedto = new ClienteDTO();

            var verifyEmail = await _clienteRepository.GetBy(c => c.Email == cliente.Email);

            if (verifyEmail == null)
            {
                var postCliente = _clienteRepository.Post(cliente);

                clientedto.Nome = postCliente.Result.Nome;
                clientedto.Email = postCliente.Result.Email;
                clientedto.Documento = postCliente.Result.Documento;
                clientedto.Phone = postCliente.Result.Phone;
            }

            return clientedto;
        }

        public Task<IEnumerable<ClienteDTO>> GetAll()
        {
            var clientedto = new ClienteDTO();

            var getClientes = _clienteRepository.GetAll();

            var listaClientes = getClientes.Result.ToList();

            var listaClienteDTO = new List<ClienteDTO>();

            for (int i = listaClientes.Count(); i != 0; i--)
            {
                clientedto.ClienteId = listaClientes[i - 1].Id;
                clientedto.Documento = listaClientes[i - 1].Documento;
                clientedto.Email = listaClientes[i - 1].Email;
                clientedto.Nome = listaClientes[i - 1].Nome;
                clientedto.Phone = listaClientes[i - 1].Phone;

                listaClienteDTO.Add(clientedto);
            }

            return Task.FromResult(listaClienteDTO.AsEnumerable());
        }

        public Task<ClienteDTO> GetById(Guid id)
        {
            var clientedto = new ClienteDTO();

            var getCliente = _clienteRepository.GetBy(c => c.Id == id);

            if (getCliente.Result != null)
            {
                clientedto.ClienteId = getCliente.Result.Id;
                clientedto.Nome = getCliente.Result.Nome;
                clientedto.Email = getCliente.Result.Email;
                clientedto.Documento = getCliente.Result.Documento;
                clientedto.Phone = getCliente.Result.Phone;
            }

            return Task.FromResult(clientedto);
        }

        public Task<ClienteDTO> Update(Cliente cliente)
        {
            var clientedto = new ClienteDTO();

            var updateCliente = _clienteRepository.Put(cliente);

            if (cliente != null)
            {
                clientedto.ClienteId = updateCliente.Result.Id;
                clientedto.Nome = updateCliente.Result.Nome;
                clientedto.Documento = updateCliente.Result.Documento;
                clientedto.Phone = updateCliente.Result.Phone;
            }

            return Task.FromResult(clientedto);
        }

        public Task<bool> Delete(Guid id)
        {
            var resposta = false;

            var getCliente = _clienteRepository.GetBy(c => c.Id == id);

            if (getCliente.Result != null)
            {
                var deleteCliente = _clienteRepository.Delete(id);
                resposta = true;
            }

            return Task.FromResult(resposta);
        }
    }
}
