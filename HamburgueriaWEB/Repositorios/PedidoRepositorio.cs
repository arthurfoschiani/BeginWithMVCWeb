using System;
using System.Collections.Generic;
using System.IO;
using HamburgueriaWEB.Models;

namespace HamburgueriaWEB.Repositorios
{
    public class PedidoRepositorio
    {
        private List<Pedido> Pedidos = new List<Pedido>();
        private string Path = "Database/Pedido.csv";
        public bool Inserir(Pedido pedido) {
            try {

            if(!File.Exists(Path)) {
                File.Create(Path).Close();
            }
            var linha = $"{pedido.ID};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.Hamburguer.Nome};{pedido.Hamburguer.Preco};{pedido.Shake.Nome};{pedido.Shake.Preco};{pedido.PrecoTotal};{pedido.DataPedido}";

            File.AppendAllText("Database/Pedido.csv", linha + "\n");

            } catch(Exception e) {
                System.Console.WriteLine("Entrou no catch");
                System.Console.WriteLine(e.StackTrace);
            }
            return true;
        }
    }
}