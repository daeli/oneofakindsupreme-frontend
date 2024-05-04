using Microsoft.Extensions.DependencyInjection;
using OneOfAKindSupreme.Frontend.Core.Interfaces;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi;
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
            // serviceCollection.AddScoped(typeof(IApi<>), typeof(Api<>));
            
            


            return serviceCollection;
        }
    }
}
