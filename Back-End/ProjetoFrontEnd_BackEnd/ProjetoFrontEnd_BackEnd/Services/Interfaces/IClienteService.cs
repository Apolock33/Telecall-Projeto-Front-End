﻿using ProjetoFrontEnd_BackEnd.DTOs;
using ProjetoFrontEnd_BackEnd.Models;
using System.Linq.Expressions;

namespace ProjetoFrontEnd_BackEnd.Services.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDTO> Create(Cliente cliente);
        Task<IEnumerable<ClienteDTO>> GetAll();
        Task<ClienteDTO> GetById(Guid id);
        Task<ClienteDTO> Verify(Cliente Cliente);
        Task<ClienteDTO> Update(Cliente cliente);
        Task<bool> Delete(Guid id);
    }
}
