using Newtonsoft.Json;
using OneOfAKindSupreme.Frontend.Core.Interfaces;
using OneOfAKindSupreme.Frontend.Core.ViewModels;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi
{
    public class ProjectsApi : Api, IProjectsApi
    {
        public const string Endpoint ="/projects";

        public async Task<IEnumerable<ProjectViewModel>> GetProjectsList()
        {
            List<ProjectViewModel> projects = new List<ProjectViewModel>();
            GetProjectsResponse response = await base.List<GetProjectsResponse>(Endpoint);
            if (response != null)
            {
                //TODO:  Move the DTO transform
                projects.AddRange(response.Projects.Select(x => new ProjectViewModel { Id = x.Id, Name = x.Name, Status = x.Status }));
            }
            return projects;
        }
    }
}
