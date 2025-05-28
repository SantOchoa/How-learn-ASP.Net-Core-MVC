using System.Text;
using ASP.Net_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Project.Controllers
{
    public class ChickenTreeController : Controller
    {
        private static ChickenTree chickenTree = new ChickenTree();
        private StringBuilder sb = new StringBuilder();
        public IActionResult Farm()
        {
            if (chickenTree.raiz == null)
            {
                chickenTree.raiz = new Chicken();
            }
            ViewData["ArbolTexto"] = chickenTree.GetTreeFormatted(chickenTree.raiz);
            return View(chickenTree);
        }
        [HttpPost]
        public IActionResult AddChicken(string nameChickenMom, string nameChickenSon)
        {
            if (string.IsNullOrEmpty(nameChickenSon))
            {
                return BadRequest("El nombre del pollo no puede estar vacío.");
            }
            else
            {
                if (chickenTree.raiz.Name == "" || chickenTree.raiz == null)
                { 
                    chickenTree.addChicken(nameChickenSon, null);
                    return RedirectToAction("Farm");
                }
                
                if (chickenTree.raiz != null && string.IsNullOrEmpty(nameChickenMom))
                {
                    return BadRequest("Ya existe una raiz"+nameChickenMom);
                }
                Chicken momChicken = chickenTree.postOrdenSearch(chickenTree.raiz, nameChickenMom);

                if (momChicken == null)
                {
                    return BadRequest("La madre no existe en el árbol."+nameChickenMom);
                }
                chickenTree.addChicken(nameChickenSon, momChicken);
                return RedirectToAction("Farm");
            }
        }
        public IActionResult ShowTree()
        {
            Chicken root = chickenTree.raiz; // este método deberías implementarlo tú

            string arbolComoTexto = chickenTree.GetTreeFormatted(chickenTree.raiz);

            ViewData["ArbolTexto"] = arbolComoTexto;

            return View();
        }
    }
}
