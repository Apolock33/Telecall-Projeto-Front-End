﻿using ProjetoModuloFrontEnd_BackEnd.Models;
using ProjetoModuloFrontEnd_BackEnd.Models.Context;
using ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces;

namespace ProjetoModuloFrontEnd_BackEnd.Repositories
{
    public class LogsRepository : Repository<Logs>, ILogsRepository
    {
        public LogsRepository(AppDbContext db) : base(db)
        {
        }
    }
}
