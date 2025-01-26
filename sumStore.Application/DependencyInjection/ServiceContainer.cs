using Microsoft.Extensions.DependencyInjection;
using sumStore.Application.Mapping;
using sumStore.Application.Services.Implementations;
using sumStore.Application.Services.Interfaces;

namespace sumStore.Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingConfig));
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IReviewService, ReviewService>();
            //services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
