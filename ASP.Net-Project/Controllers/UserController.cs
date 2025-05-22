using System.Threading;
using Microsoft.AspNetCore.Mvc;
using ASP.Net_Project.Models;

namespace ASP.Net_Project.Controllers
{
    public class UserController : Controller
    {
        
        private static List<User> users = new List<User>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        
        public IActionResult saveUser(string  nameUser,int idUser, string passwordUser)
        {
            
            User user = new User(idUser, nameUser, passwordUser);
            
            users.Add(user);
            
            return RedirectToAction("Login");
        }
        
    }
}
