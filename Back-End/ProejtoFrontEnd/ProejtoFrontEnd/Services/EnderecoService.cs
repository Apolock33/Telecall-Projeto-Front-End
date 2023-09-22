using ProejtoFrontEnd.Repositories.Interfaces;
using ProejtoFrontEnd.Services.Interfaces;
using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using System.Net;
using Microsoft.AspNetCore.Http.HttpResults;
using ProejtoFrontEnd.Repositories;

namespace ProejtoFrontEnd.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public async Task<EnderecoDTO> PostEndereco(Endereco endereco)
        {
            var enderecoDto = new EnderecoDTO();

            endereco.EnderecoId = Guid.NewGuid();
            endereco.UsuarioId = Guid.NewGuid();

            var getEnd = await _enderecoRepository.Find(e => e.Rua == endereco.Rua);

            if (!getEnd.Any())
            {
                var postEnd = await _enderecoRepository.Add(endereco);

                enderecoDto.EnderecoId = endereco.EnderecoId;
                enderecoDto.Rua = endereco.Rua;
                enderecoDto.Numero = endereco.Numero;
                enderecoDto.Complemento = endereco.Complemento;
                enderecoDto.Bairro = endereco.Bairro;
                enderecoDto.Cidade = endereco.Cidade;
                enderecoDto.Estado = endereco.Estado;
            }
            return enderecoDto;
        }
    }
}
