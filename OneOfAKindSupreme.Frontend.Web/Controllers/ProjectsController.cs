using Microsoft.AspNetCore.Mvc;
using OneOfAKindSupreme.Frontend.Core.Interfaces.Domain;

namespace OneOfAKindSupreme.Frontend.Web.Controllers
{
    public class ProjectsController : Controller
    {
        private IGetProjectsList getProjectsList;
        private ICreateProject createProject;
        public ProjectsController(IGetProjectsList getProjectsList, ICreateProject createProject) 
        { 
            this.getProjectsList = getProjectsList;
            this.createProject = createProject;
        }

        public async Task<IActionResult> Index()
        {
          
            var list = await getProjectsList.GetList();
            ViewData["projects"] = list;

            return View();
        }

        public IActionResult Add()
        { 
            return View();
        }


        public IActionResult AddProject(string projectName, string projectStatus)
        {            
            createProject.CreateNewProject(projectName, projectStatus);
            return RedirectToAction("Index");            
        }
    }
}
