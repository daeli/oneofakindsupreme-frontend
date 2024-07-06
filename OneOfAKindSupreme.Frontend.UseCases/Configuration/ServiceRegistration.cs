using Microsoft.Extensions.DependencyInjection;
using OneOfAKindSupreme.Frontend.Core.Interfaces.Domain;
using OneOfAKindSupreme.Frontend.UseCases.Access;
using OneOfAKindSupreme.Frontend.UseCases.Projects;

namespace OneOfAKindSupreme.Frontend.UseCases.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterUseCaseServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IGetProjectsList, GetProjectsList>();
            serviceCollection.AddScoped<ICreateProject, CreateProject>();
            serviceCollection.AddScoped<ISignIn, SignIn>();

            return serviceCollection;
        }
    }
}
