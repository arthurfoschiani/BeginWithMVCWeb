using Microsoft.AspNetCore.Mvc;
using WebMVC_Manha.Models;
using WebMVC_Manha.Repositorios;

namespace WebMVC_Manha.Controllers
{
    public class MusicaController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Welcome(string nome)
        {
            
            
            ViewData["Mensagem"] = "Olá " + nome + ", estas são as suas músicas";
            var musica = MusicaRepositorio.musicas[0];
            

            return View(musica);
        }
    }
}