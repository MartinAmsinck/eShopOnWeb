﻿using MediatR;
using Effektiv.Web.Interfaces;
using Effektiv.Web.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Effektiv.Web.Configuration
{
    public static class ConfigureWebServices
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(BasketViewModelService).Assembly);
            services.AddScoped<IBasketViewModelService, BasketViewModelService>();
            services.AddScoped<CatalogViewModelService>();
            services.AddScoped<ICatalogItemViewModelService, CatalogItemViewModelService>();
            services.Configure<CatalogSettings>(configuration);
            services.AddScoped<ICatalogViewModelService, CachedCatalogViewModelService>();
        }
    }
}
