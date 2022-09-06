using Microsoft.Extensions.DependencyInjection;
using NSE.Catalogo.API.Contracts;
using NSE.Catalogo.API.Data;
using NSE.Catalogo.API.Repository;

namespace NSE.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
