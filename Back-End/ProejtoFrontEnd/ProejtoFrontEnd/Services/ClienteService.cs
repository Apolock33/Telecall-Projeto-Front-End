using Microsoft.AspNetCore.Mvc;
using ProejtoFrontEnd.Repositories.Interfaces;
using ProejtoFrontEnd.Services.Interfaces;
using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using System.Net;

namespace ProejtoFrontEnd.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClientesRepository _clienteRepository;

        public ClienteService(IClientesRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<ClienteDTO> PostCliente(Cliente cliente)
        {
            var clienteDto = new ClienteDTO();

            var clienteExiste = await _clienteRepository.Find(c => c.Email == cliente.Email);

            if (clienteExiste.Count() == 0)
            {
                cliente.Id = Guid.NewGuid();

                var cadastrarCliente = await _clienteRepository.Add(cliente);

                clienteDto.ClienteId = cliente.Id;
                clienteDto.Nome = cliente.Nome;
                clienteDto.Documento = cliente.Documento;
                clienteDto.Email = cliente.Email;
                clienteDto.Phone = cliente.Phone;
            }

            return clienteDto;
        }

        public async Task<IEnumerable<ClienteDTO>> GetAllClientes()
        {
            var clienteDto = new ClienteDTO();

            var listaDeClientes = new List<ClienteDTO>();

            var listarClientes = await _clienteRepository.GetAll();

            foreach (var item in listarClientes)
            {
                clienteDto.ClienteId = item.Id;
                clienteDto.Nome = item.Nome;
                clienteDto.Documento = item.Documento;
                clienteDto.Email = item.Email;
                clienteDto.Phone = item.Phone;

                listaDeClientes.Add(clienteDto);
            }

            return listaDeClientes.AsEnumerable();
        }

        public async Task<IEnumerable<ClienteDTO>> GetCliente(Guid id)
        {
            var clienteDto = new ClienteDTO();

            var listCliente = new List<ClienteDTO>();

            var clienteExiste = await _clienteRepository.Find(c => c.Id == id);

            foreach (var item in clienteExiste)
            {
                clienteDto.ClienteId = item.Id;
                clienteDto.Nome = item.Nome;
                clienteDto.Email = item.Email;
                clienteDto.Documento = item.Documento;
                clienteDto.Phone = item.Phone;

                listCliente.Add(clienteDto);
            }

            return listCliente;
        }

        public async Task<ClienteDTO> PutCliente(Cliente cliente)
        {
            var clienteDto = new ClienteDTO();

            var clienteExiste = await _clienteRepository.Find(c => c.Id == cliente.Id);

            if (clienteExiste.Any())
            {
                foreach (var item in clienteExiste)
                {
                    item.Nome = cliente.Nome;
                    item.Email = cliente.Email;
                    item.Phone = cliente.Phone;
                    item.Documento = cliente.Documento;

                    var atualizarCliente = await _clienteRepository.Update(item);

                    clienteDto.ClienteId = atualizarCliente.Id;
                    clienteDto.Nome = atualizarCliente.Nome;
                    clienteDto.Documento = atualizarCliente.Documento;
                    clienteDto.Email = atualizarCliente.Email;
                    clienteDto.Phone = atualizarCliente.Phone;
                }
            }

            return clienteDto;
        }

        public async Task<bool> DeleteCliente(Guid id)
        {
            var resposta = false;

            var getCliente = await _clienteRepository.GetById(id);

            if (getCliente.Documento != null)
            {
                var deletarCliente = await _clienteRepository.Delete(id);

                resposta = true;
            }

            return resposta;
        }
    }
}
