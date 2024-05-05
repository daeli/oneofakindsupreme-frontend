using OneOfAKindSupreme.Frontend.Core.ViewModels;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Transforms
{
    public static class ProjectTransforms
    {
        public static IEnumerable<ProjectViewModel> ToProjectViewModels(this IEnumerable<Data.OneOfAKindSupremeApi.DTOs.Project> apiProjects) 
        {
            return apiProjects.Select(x => new ProjectViewModel { Id = x.Id, Name = x.Name, Status = x.Status });
        }
    }
}
