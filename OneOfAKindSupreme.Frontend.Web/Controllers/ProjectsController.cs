using Microsoft.AspNetCore.Mvc;
using OneOfAKindSupreme.Frontend.Core.Interfaces;

namespace OneOfAKindSupreme.Frontend.Web.Controllers
{
    public class ProjectsController : Controller
    {
        private IGetProjectsList getProjectsList;
        public ProjectsController(IGetProjectsList getProjectsList) 
        { 
            this.getProjectsList = getProjectsList; 
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
    }
}
