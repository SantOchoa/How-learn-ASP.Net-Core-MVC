using System.Threading;
using Microsoft.AspNetCore.Mvc;
using ASP.Net_Project.Models;

namespace ASP.Net_Project.Controllers
{
    public class UserController : Controller
    {
        // Lista de tareas pendientes (puede usarse como colección principal)
        private static List<User> tareas = new List<User>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
