using Microsoft.AspNetCore.Mvc;
using OneOfAKindSupreme.Frontend.Infrastructure.Data.OneOfAKindSupremeApi;
using OneOfAKindSupreme.Frontend.UseCases.Projects;

namespace OneOfAKindSupreme.Frontend.Web.Controllers
{
    public class ProjectsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //TODO:  Register this dependency and get from container.
            var list = await new GetProjectsList(new ProjectsApi()).GetList();

            return View();
        }
    }
}
