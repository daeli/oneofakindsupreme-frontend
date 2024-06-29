using OneOfAKindSupreme.Frontend.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneOfAKindSupreme.Frontend.Core.Interfaces.Domain
{
    public interface ICreateProject
    {
        Task<ProjectViewModel> CreateNewProject(string projectName, string projectStatus);
    }
}
