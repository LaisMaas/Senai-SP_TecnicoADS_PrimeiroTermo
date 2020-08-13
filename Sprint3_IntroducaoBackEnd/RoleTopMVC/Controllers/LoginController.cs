using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModel;

namespace RoleTopMVC.Controllers
{
    public class LoginController: AbstractController
    {
        public IActionResult Login()
        {
            return View(new BaseViewModel(){
                NomeView = "Login"               
            });
        }    
    }
}