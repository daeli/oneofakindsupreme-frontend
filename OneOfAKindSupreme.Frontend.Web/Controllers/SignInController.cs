using Microsoft.AspNetCore.Mvc;
using OneOfAKindSupreme.Frontend.Core.Interfaces.Domain;

namespace OneOfAKindSupreme.Frontend.Web.Controllers
{
    public class SignInController : Controller
    {
        private readonly ISignIn signIn;
        public SignInController(ISignIn signIn) 
        { 
            this.signIn = signIn; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> LogOnAsync(string loginEmail, string loginPassword)
        {
            var result = await signIn.ValidateCredentials(loginEmail, loginPassword);
            if(result.IsSuccess) {
                return RedirectToAction("Index", "Home");            
            }

            return RedirectToAction("Index");
        }
    }
}
