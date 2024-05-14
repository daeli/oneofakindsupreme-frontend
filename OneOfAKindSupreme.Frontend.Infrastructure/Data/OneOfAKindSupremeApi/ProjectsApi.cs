using OneOfAKindSupreme.Frontend.Core.Interfaces;
using OneOfAKindSupreme.Frontend.Core.ViewModels;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.Responses;
using OneOfAKindSupreme.Frontend.Infrastructure.Transforms;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi
{
    public class ProjectsApi : Api, IProjectsApi
    {
        public const string Endpoint ="/projects";

        public async Task<List<ProjectViewModel>> GetProjectsList()
        {
            List<ProjectViewModel> projects = new List<ProjectViewModel>();
            GetProjectsResponse response = await base.List<GetProjectsResponse>(Endpoint);
            if (response != null && response.Projects != null)
            {                
                projects.AddRange(response.Projects.ToProjectViewModels());
            }
            return projects;
        }
    }
}
