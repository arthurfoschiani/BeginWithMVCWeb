using System;
using EstacionamentoWEB.Models;
using EstacionamentoWEB.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstacionamentoWEB.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            System.Console.WriteLine(form["nomeUsuario"]);
            System.Console.WriteLine(form["modelo"]);
            System.Console.WriteLine(form["marca"]);
            System.Console.WriteLine(form["placa"]);
            System.Console.WriteLine(form["momentoDaEntrada"]);



            CarroModel carro = new CarroModel();
            carro.Id = int.Parse(form["id"]);
            carro.NomeUsuario = form["nomeUsuario"];
            carro.Placa = form["placa"];
            carro.MomentoDaEntrada = DateTime.Parse(form["momentoDaEntrada"]);

            MarcaModel Marca = new MarcaModel();
            Marca.Nome = form["nome"];

            ModeloModel Modelo = new ModeloModel();
            Modelo.Nome = form["nome"];

            
        }

        [HttpGet]
        public IActionResult Listar() {
            CarroRepositorio carroRepositorio = new CarroRepositorio();
            ViewData["Carros"] = carroRepositorio.ListarCarros();

            return View();
        }
    }
}
