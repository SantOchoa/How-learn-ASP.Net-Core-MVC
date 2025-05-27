using ASP.Net_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Project.Controllers
{
    public class ChickenTreeController : Controller
    {
        ChickenTree chickenTree = new ChickenTree();
        public IActionResult Farm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddChicken(string nameChicken)
        {
            if (string.IsNullOrEmpty(nameChicken))
            {
                return BadRequest("El nombre del pollo no puede estar vacío.");
            }
            Chicken newChicken = new Chicken(nameChicken);
            chickenTree.addChicken(nameChicken, newChicken);
            return RedirectToAction("Index");
        }
    }
}
