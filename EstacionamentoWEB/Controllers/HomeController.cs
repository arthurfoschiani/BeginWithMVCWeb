using System;
using EstacionamentoWEB.Models;
using EstacionamentoWEB.Repositorio;
using EstacionamentoWEB.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstacionamentoWEB.Controllers
{
    public class HomeController : Controller
    {
        EntradaRepositorio entrarRepositorio = new EntradaRepositorio();
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();

        [HttpGet]
        public IActionResult Index() {
            var marcas = marcaRepositorio.Listar();
            var modelos = modeloRepositorio.Listar();

            EntradaViewModel entrada = new EntradaViewModel();
            entrada.Marcas = marcas;
            entrada.Modelos = modelos;

            return View(entrada);
        }

        [HttpPost]
        public IActionResult RegistrarEntrada(IFormCollection form) {
            System.Console.WriteLine("nome");
            System.Console.WriteLine("marca");
            System.Console.WriteLine("modelo");
            System.Console.WriteLine("placa");

            Entrada entrada = new Entrada();
            
            entrada.Usuario = form["nome"];

            Marca marca = new Marca();
            marca.Nome = form["marca"];

            entrada.Marca = marca.Nome;

            Modelo modelo = new Modelo();
            modelo.Nome = form["modelo"];

            entrada.Modelo = modelo.Nome;

            Placa placa = new Placa();
            placa.Nome = form["placa"];

            entrada.Placa = placa.Nome;

            entrada.DataEntrada = DateTime.Now;

            entrarRepositorio.Inserir(entrada);

            return View("Sucesso");
        }

        [HttpGet]
        public IActionResult Listar(){
            EntradaRepositorio entradaRepositorio = new EntradaRepositorio();
            ViewData["entrada"] = entradaRepositorio.ListarEntrada();

            return View();
        }
    }
}
