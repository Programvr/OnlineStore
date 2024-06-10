using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Application.Handlers;
using OnlineStore.Infrastructure.Persistence;
using OnlineStore.Infrastructure.Repositories;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Configurar servicios
builder.Services.AddMassTransit(x =>
{
    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host(new Uri("rabbitmq://localhost:5672"), h =>
        {
            h.Username("guest");
            h.Password("guest");
        });
    });
});

// Configurar DbContext
builder.Services.AddDbContext<OnlineStoreDbContext>(options =>
{
    var serverVersion = new MariaDbServerVersion(new Version(10, 4, 32));
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), serverVersion);
});

// Repositorios
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();

// Configurar MediatR
builder.Services.AddMediatR(typeof(CrearPedidoCommandHandler).Assembly);

builder.Services.AddControllers();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configurar el pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();
