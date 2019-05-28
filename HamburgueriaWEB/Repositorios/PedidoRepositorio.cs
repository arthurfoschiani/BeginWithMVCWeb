using System.IO;
using System.Collections.Generic;
using Hamburgueria_Manha.Models;
using System;

namespace Hamburgueria_Manha.Repositorios
{
    public class PedidoRepositorio
    {
        private List<Pedido> Pedidos = new List<Pedido>();

        private string Path = "Database/Pedido.csv";

        public bool Inserir(Pedido pedido)
        {
            try {

                if(!File.Exists(Path)){
                    File.Create(Path).Close();
                }

                var linha = $"{pedido.Id};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.Hamburguer.Nome}; {pedido.Shake.Nome};{pedido.DataPedido}";

                File.AppendAllText(Path, linha + "\n");

            } catch(Exception e) {
                System.Console.WriteLine("Entrou no catch");
                System.Console.WriteLine(e.StackTrace);
            }

            return true;
        }
    }
}