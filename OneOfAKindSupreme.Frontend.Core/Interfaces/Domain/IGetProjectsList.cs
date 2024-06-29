using OneOfAKindSupreme.Frontend.Core.ViewModels;

namespace OneOfAKindSupreme.Frontend.Core.Interfaces.Domain
{
    public interface IGetProjectsList
    {
        Task<List<ProjectViewModel>> GetList();
    }
}
