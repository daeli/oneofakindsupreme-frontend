using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;
using OneOfAKindSupreme.Frontend.Core.ViewModels;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.DTOs;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.Responses;
using OneOfAKindSupreme.Frontend.Infrastructure.Transforms;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi
{
    public class ProjectsApi : Api, IProjectsApi
    {
        public const string Endpoint ="/projects";

        public async Task<List<ProjectViewModel>> GetProjectsList()
        {
            List<ProjectViewModel> projects = [];
            GetProjectsResponse? response = await GetFromApiAsync<GetProjectsResponse>(Endpoint);
            if (response != null && response.Projects != null)
            {                
                projects.AddRange(response.Projects.ToProjectViewModels());
            }
            return projects; 
        }

        public async Task<ProjectViewModel?> CreateNewProject(string projectName, string projectStatus) 
        {            
            CreateNewProjectResponse? response = await PostToApiAsync<CreateNewProjectResponse>(Endpoint, new NewProject { Name = projectName, Status = projectStatus });
            if (response != null && response.Project != null) 
            {
                return response.Project.ToProjectViewModel();
            }
            return null;
        }
    }
}
