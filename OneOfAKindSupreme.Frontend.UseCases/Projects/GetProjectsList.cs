using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneOfAKindSupreme.Frontend.Core.Interfaces;
using OneOfAKindSupreme.Frontend.Core.ViewModels;
namespace OneOfAKindSupreme.Frontend.UseCases.Projects
{
    public class GetProjectsList
    {
        private readonly IProjectsApi api;
        public GetProjectsList(IProjectsApi api) 
        { 
            this.api = api; 
        }

        public async Task<IEnumerable<ProjectViewModel>> GetList() 
        {
            var result = await api.GetProjectsList();

            return result;
        }
    }
}
