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
                enderecoDto.UsuarioId = endereco.UsuarioId;
                enderecoDto.Rua = endereco.Rua;
                enderecoDto.Numero = endereco.Numero;
                enderecoDto.Complemento = endereco.Complemento;
                enderecoDto.Bairro = endereco.Bairro;
                enderecoDto.Cidade = endereco.Cidade;
                enderecoDto.Estado = endereco.Estado;
            }
            return enderecoDto;
        }

        public async Task<IEnumerable<EnderecoDTO>> GetAllEnderecos()
        {
            var enderecoDto = new EnderecoDTO();

            var listaEndereco = new List<EnderecoDTO>();

            var getAll = await _enderecoRepository.GetAll();

            if (getAll.Any())
            {
                foreach (var item in getAll)
                {
                    enderecoDto.EnderecoId = item.EnderecoId;
                    enderecoDto.UsuarioId = item.UsuarioId;
                    enderecoDto.Rua = item.Rua;
                    enderecoDto.Numero = item.Numero;
                    enderecoDto.Complemento = item.Complemento;
                    enderecoDto.Bairro = item.Bairro;
                    enderecoDto.Cidade = item.Cidade;
                    enderecoDto.Estado = item.Estado;

                    listaEndereco.Add(enderecoDto);
                }
            }

            return listaEndereco.AsEnumerable();
        }

        public async Task<IEnumerable<EnderecoDTO>> GetEndereco(Guid id)
        {
            var enderecoDto = new EnderecoDTO();

            var listaEndereco = new List<EnderecoDTO>();

            var getAll = await _enderecoRepository.Find(e => e.EnderecoId == id);

            if (getAll.Any())
            {
                foreach (var item in getAll)
                {
                    enderecoDto.EnderecoId = item.EnderecoId;
                    enderecoDto.UsuarioId = item.UsuarioId;
                    enderecoDto.Rua = item.Rua;
                    enderecoDto.Numero = item.Numero;
                    enderecoDto.Complemento = item.Complemento;
                    enderecoDto.Bairro = item.Bairro;
                    enderecoDto.Cidade = item.Cidade;
                    enderecoDto.Estado = item.Estado;

                    listaEndereco.Add(enderecoDto);
                }
            }

            return listaEndereco.AsEnumerable();
        }

        public async Task<EnderecoDTO> PutEndereco(Endereco endereco)
        {
            var enderecoDto = new EnderecoDTO();

            var getEnd = await _enderecoRepository.Find(e => e.EnderecoId == endereco.EnderecoId);

            if (getEnd.Any())
            {
                foreach (var item in getEnd)
                {
                    item.EnderecoId = endereco.EnderecoId;
                    item.UsuarioId = endereco.UsuarioId;
                    item.Rua = endereco.Rua;
                    item.Numero = endereco.Numero;
                    item.Complemento = endereco.Complemento;
                    item.Bairro = endereco.Bairro;
                    item.Cidade = endereco.Cidade;
                    item.Estado = endereco.Estado;

                    var putEnd = await _enderecoRepository.Update(item);

                    enderecoDto.EnderecoId = item.EnderecoId;
                    enderecoDto.UsuarioId = item.UsuarioId;
                    enderecoDto.Rua = item.Rua;
                    enderecoDto.Numero = item.Numero;
                    enderecoDto.Complemento = item.Complemento;
                    enderecoDto.Bairro = item.Bairro;
                    enderecoDto.Cidade = item.Cidade;
                    enderecoDto.Estado = item.Estado;
                }
            }

            return enderecoDto;
        }

        public async Task<bool> DeleteEndereco(Guid id)
        {
            var resposta = false;

            var getEndereco = await _enderecoRepository.GetById(id);

            if (getEndereco != null)
            {
                var deleteEndereco = await _enderecoRepository.Delete(id);

                resposta = true;
            }

            return resposta;
        }
    }
}
