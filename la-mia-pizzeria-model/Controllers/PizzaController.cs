using la_mia_pizzeria_model.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_model.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Homepage";
            using var ctx = new PizzaContext();

            var menu = ctx.Pizzas.ToArray();
            if (!ctx.Pizzas.Any())
            {
                ViewData["Message"] = "Nessun risultato trovato";
            }
            return View("Index", menu);
        }

        public IActionResult Show(long id)
        {
            using var ctx = new PizzaContext();
            var menuItem = ctx.Pizzas.Find(id);

            return View(menuItem);
        }
    }
}
