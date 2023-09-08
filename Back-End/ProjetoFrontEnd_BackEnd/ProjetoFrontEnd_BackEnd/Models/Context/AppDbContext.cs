﻿using Microsoft.EntityFrameworkCore;

namespace ProjetoFrontEnd_BackEnd.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
