using Microsoft.AspNetCore.Mvc;

namespace OneOfAKindSupreme.Frontend.Web.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
