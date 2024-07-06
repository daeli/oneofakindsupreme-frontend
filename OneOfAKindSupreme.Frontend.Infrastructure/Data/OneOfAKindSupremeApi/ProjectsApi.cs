using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;
using OneOfAKindSupreme.Frontend.Core.ViewModels;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.DTOs;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.Responses;
using OneOfAKindSupreme.Frontend.Infrastructure.Transforms;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi
{
    public class ProjectsApi(IApi api) : IProjectsApi
    {
        public const string ProjectsEndpoint ="/projects";

        private readonly IApi api = api;

        public async Task<List<ProjectViewModel>> GetProjectsList()
        {
            List<ProjectViewModel> projects = [];
            GetProjectsResponse? response = await api.GetFromApiAsync<GetProjectsResponse>(ProjectsEndpoint);
            if (response != null && response.Projects != null)
            {                
                projects.AddRange(response.Projects.ToProjectViewModels());
            }
            return projects; 
        }

        public async Task<ProjectViewModel?> CreateNewProject(string projectName, string projectStatus) 
        {            
            CreateNewProjectResponse? response = await api.PostToApiAsync<CreateNewProjectResponse>(ProjectsEndpoint, new NewProject { Name = projectName, Status = projectStatus });
            if (response != null && response.Project != null) 
            {
                return response.Project.ToProjectViewModel();
            }
            return null;
        }
    }
}
