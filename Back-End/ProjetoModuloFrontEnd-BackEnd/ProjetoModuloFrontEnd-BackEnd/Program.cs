using Microsoft.EntityFrameworkCore;
using ProjetoModuloFrontEnd_BackEnd.Models.Context;
using ProjetoModuloFrontEnd_BackEnd.Repositories;
using ProjetoModuloFrontEnd_BackEnd.Repositories.Interfaces;
using ProjetoModuloFrontEnd_BackEnd.Services;
using ProjetoModuloFrontEnd_BackEnd.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region Context
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
#endregion

#region Repository
builder.Services.AddTransient<IClientesRepository, ClientesRepository>();
builder.Services.AddTransient<IContasRepository, ContasRepository>();
builder.Services.AddTransient<ILinhasRepository, LinhasRepository>();
builder.Services.AddTransient<ILogsRepository, LogsRepository>();
builder.Services.AddTransient<IEnderecosRepository, EnderecosRepository>();
builder.Services.AddTransient<IUsuariosRepository, UsuariosRepository>();
#endregion

#region Service
builder.Services.AddTransient<IClientesService, ClientesService>();
builder.Services.AddTransient<IContasService, ContasService>();
builder.Services.AddTransient<ILinhasService, LinhasService>();
builder.Services.AddTransient<ILogsService, LogsService>();
 
#endregion
//string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: MyAllowSpecificOrigins,
//        builder =>
//        {
//            builder.WithOrigins();
//        });
//});

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

//app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
