using OneOfAKindSupreme.Frontend.Core.ViewModels;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Transforms
{
    public static class ProjectTransforms
    {
        public static IEnumerable<ProjectViewModel> ToProjectViewModels(this IEnumerable<Data.OneOfAKindSupremeApi.DTOs.Project> apiProjects) 
        {
            return apiProjects.Select(x => x.ToProjectViewModel());
        }

        public static ProjectViewModel ToProjectViewModel(this Data.OneOfAKindSupremeApi.DTOs.Project apiProject)
        {
            return new ProjectViewModel { Id = apiProject.Id, Name = apiProject.Name, Status = apiProject.Status };
        }
    }
}
