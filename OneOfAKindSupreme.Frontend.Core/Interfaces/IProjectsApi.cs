
using OneOfAKindSupreme.Frontend.Core.ViewModels;

namespace OneOfAKindSupreme.Frontend.Core.Interfaces
{
    public interface IProjectsApi
    {
        Task<List<ProjectViewModel>> GetProjectsList();
    }
}
