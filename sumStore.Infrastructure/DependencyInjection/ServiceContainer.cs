
using EntityFramework.Exceptions.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sumStore.Domain.Entities;
using sumStore.Domain.Interfaces;
using sumStore.Infrastructure.Data;
using sumStore.Infrastructure.Repositories;

namespace sumStore.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>
                (options => 
                    options.UseSqlServer
                ( config.GetConnectionString("DefaultConnection"),
                    sqlOptions =>
                    {
                        sqlOptions.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
                        sqlOptions.EnableRetryOnFailure(); //Enable automatic retries for trasient failures
                    }
                ).UseExceptionProcessor(), //Exceptions comming from ExceptionHAndlingMiddleware
                   ServiceLifetime.Scoped
                );
            services.AddScoped<IGeneric<Brand>, GenericRepository<Brand>>();
            services.AddScoped<IGeneric<Category>, GenericRepository<Category>>();
            services.AddScoped<IGeneric<Product>, GenericRepository<Product>>();
            services.AddScoped<IGeneric<Review>, GenericRepository<Review>>();
            //services.AddScoped<IGeneric<User>, GenericRepository<User>>();
            return services;
        }
    }
}
