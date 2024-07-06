using OneOfAKindSupreme.Frontend.Core.ViewModels;

namespace OneOfAKindSupreme.Frontend.Core.Interfaces.Domain
{
    public interface ICreateProject
    {
        Task<ProjectViewModel> CreateNewProject(string projectName, string projectStatus);
    }
}
