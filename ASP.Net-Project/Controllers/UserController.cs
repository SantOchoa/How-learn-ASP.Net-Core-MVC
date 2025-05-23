using System.Threading;
using Microsoft.AspNetCore.Mvc;
using ASP.Net_Project.Models;
using System.Text;

namespace ASP.Net_Project.Controllers
{
    public class UserController : Controller
    {

        public static List<User> users = new List<User>();
        
        public IActionResult Login()
        {
            return View(users);
        }


        [HttpPost]
        public IActionResult saveUser(string nameUser, int idUser, string passwordUser)
        {

            User user = new User(idUser, nameUser, passwordUser);

            users.Add(user);

            return RedirectToAction("Login");
        }
        [HttpPost]
        public IActionResult showUsers()
        {
            StringBuilder sb = new StringBuilder();
            foreach (User user in users)
            {
                sb.Append(user.toString());
            }
            return Content(sb.ToString());
        }
    }
}

