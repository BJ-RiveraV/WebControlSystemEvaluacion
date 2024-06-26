using HTTPClienteData.Clientes;
using HTTPClienteData.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HTTPClienteData
{
    public static class HTTPClienteDataServiceRegistration
    {
        public static IServiceCollection AddHTTPClienteDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<IClienteUsuarios, ClienteUsuarios>();
            services.AddHttpClient<IClienteGeo, ClienteGeo>();

            return services;
        }
    }
}
