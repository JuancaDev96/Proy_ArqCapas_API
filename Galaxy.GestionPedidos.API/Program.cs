using Galaxy.GestionPedidos.AccesoDatos.Contexto;
using Galaxy.GestionPedidos.Repositorios.Implementaciones;
using Galaxy.GestionPedidos.Repositorios.Interfaces;
using Galaxy.GestionPedidos.Servicios.Implementaciones;
using Galaxy.GestionPedidos.Servicios.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BdPedidosContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BdPedidos"));
});

builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();

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
