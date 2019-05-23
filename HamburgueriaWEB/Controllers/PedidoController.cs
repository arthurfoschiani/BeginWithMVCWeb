using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaWEB.Controllers
{
    public class PedidoController : Controller
    {
        [HttpGet]
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form) {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["hamburguer"]);
            System.Console.WriteLine(form["shake"]);

            return RedirectToAction("Index", "Home");
        }
    }
}