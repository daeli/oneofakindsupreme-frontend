﻿using Microsoft.Extensions.DependencyInjection;
using OneOfAKindSupreme.Frontend.Core.Interfaces;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IApi), typeof(Api));
            serviceCollection.AddScoped(typeof(IProjectsApi), typeof(ProjectsApi));

            return serviceCollection;
        }
    }
}