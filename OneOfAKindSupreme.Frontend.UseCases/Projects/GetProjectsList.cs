using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneOfAKindSupreme.Frontend.Core.Interfaces.Api;
using OneOfAKindSupreme.Frontend.Core.Interfaces.Domain;
using OneOfAKindSupreme.Frontend.Core.ViewModels;
namespace OneOfAKindSupreme.Frontend.UseCases.Projects
{
    public class GetProjectsList : IGetProjectsList
    {
        private readonly IProjectsApi api;
        public GetProjectsList(IProjectsApi api) 
        { 
            this.api = api; 
        }

        public async Task<List<ProjectViewModel>> GetList() 
        {
            var result = await api.GetProjectsList();

            return result;
        }
    }
}
