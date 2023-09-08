using Microsoft.EntityFrameworkCore;
using ProjetoFrontEnd_BackEnd.Models.Context;
using ProjetoFrontEnd_BackEnd.Repositories;
using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.Services;
using ProjetoFrontEnd_BackEnd.Services.Interfaces;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Context
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
#endregion

#region Repository
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
#endregion

#region Service
builder.Services.AddTransient<IClienteService, ClienteService>();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
