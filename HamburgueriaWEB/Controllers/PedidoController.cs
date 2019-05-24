using System;
using HamburgueriaWEB.Models;
using HamburgueriaWEB.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaWEB.Controllers
{
    public class PedidoController : Controller
    {
        PedidoRepositorio pedidoRepositorio = new PedidoRepositorio();

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

            Pedido pedido = new Pedido();

            // Instanciação de objeto - Forma 1
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;

            // Instanciação de objeto - Forma 2 (pede geração de construtor)
            Hamburguer hamburguer = new Hamburguer(
                Nome: form["hamburguer"]
            );
            pedido.Hamburguer = hamburguer;

            // Instanciação de objeto - Forma 3 (resumo forma 1)
            Shake shake = new Shake() {
                Nome = form["shake"]
            };
            pedido.Shake = shake;

            pedido.DataPedido = DateTime.Now;

            pedidoRepositorio.Inserir(pedido);

            ViewData["Controller"] = "Pedido";

            return View("Sucesso");

            // return RedirectToAction("Index", "Home");
        }
    }
}