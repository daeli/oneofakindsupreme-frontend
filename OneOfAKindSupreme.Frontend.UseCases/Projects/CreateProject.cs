using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;
using OneOfAKindSupreme.Frontend.Core.Interfaces.Domain;
using OneOfAKindSupreme.Frontend.Core.ViewModels;

namespace OneOfAKindSupreme.Frontend.UseCases.Projects
{
    public class CreateProject : ICreateProject
    {
        private readonly IProjectsApi api;
        public CreateProject(IProjectsApi api)
        {
            this.api = api;
        }

        public async Task<ProjectViewModel> CreateNewProject(string projectName, string projectStatus)
        {
            return await api.CreateNewProject(projectName, projectStatus.ToLower());
        }
    }
}
