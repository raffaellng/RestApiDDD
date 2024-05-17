using Autofac.Core;
using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Application.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Services;
using RestApiModeloDDD.Infrastructure.Data;
using RestApiModeloDDD.Infrastructure.Data.Repositorys;

namespace RestApiModeloDDD.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connection = builder.Configuration["SqlConnection:SqlConnectionString"];
            builder.Services.AddDbContext<SqlContext>(options =>
            {
                options.UseSqlServer(connection);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IApplicationServiceClientes, ApplicationServiceCliente>();
            builder.Services.AddScoped<IApplicationServiceProduto, ApplicationServiceProduto>();
            builder.Services.AddScoped<IServiceCliente, ServiceCliente>();
            builder.Services.AddScoped<IServiceProduto, ServiceProduto>();
            builder.Services.AddScoped<IRepositoryCliente, RepositoryCliente>();
            builder.Services.AddScoped<IRepositoryProduto, RepositoryProduto>();
            builder.Services.AddScoped<IMapperCliente, MapperCliente>();
            builder.Services.AddScoped<IMapperProduto, MapperProduto>();


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
        }
    }
}