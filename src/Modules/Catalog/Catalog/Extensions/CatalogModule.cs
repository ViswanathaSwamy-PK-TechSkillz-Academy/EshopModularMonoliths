using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Extensions;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddDbContext<CatalogDbContext>(options =>
        //{
        //    options.UseSqlServer("Server=.;Initial Catalog=EShopMMA.CatalogDb;Integrated Security=true");
        //});
        //services.AddScoped<IProductRepository, ProductRepository>();
        //services.AddScoped<IProductService, ProductService>();

        return services;
    }
}
