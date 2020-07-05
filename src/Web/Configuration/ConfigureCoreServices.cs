using Effektiv.ApplicationCore.Interfaces;
using Effektiv.ApplicationCore.Services;
using Effektiv.Infrastructure.Data;
using Effektiv.Infrastructure.Logging;
using Effektiv.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Effektiv.Web.Configuration
{
    public static class ConfigureCoreServices
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddSingleton<IUriComposer>(new UriComposer(configuration.Get<CatalogSettings>()));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddTransient<IEmailSender, EmailSender>();
        }
    }
}
