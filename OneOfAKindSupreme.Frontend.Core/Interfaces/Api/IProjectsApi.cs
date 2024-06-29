using OneOfAKindSupreme.Frontend.Core.ViewModels;

namespace OneOfAKindSupreme.Frontend.Core.Interfaces.Api
{
    public interface IProjectsApi
    {
        Task<List<ProjectViewModel>> GetProjectsList();
        Task<ProjectViewModel?> CreateNewProject(string projectName, string projectStatus);
    }
}
