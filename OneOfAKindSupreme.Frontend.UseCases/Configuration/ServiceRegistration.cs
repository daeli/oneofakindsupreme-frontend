using Microsoft.Extensions.DependencyInjection;
using OneOfAKindSupreme.Frontend.Core.Interfaces;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi;
using OneOfAKindSupreme.Frontend.UseCases.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneOfAKindSupreme.Frontend.UseCases.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterUseCaseServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IGetProjectsList, GetProjectsList>();

            return serviceCollection;
        }
    }
}
