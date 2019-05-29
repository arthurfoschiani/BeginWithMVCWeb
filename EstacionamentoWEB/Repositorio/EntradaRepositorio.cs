using System;
using System.Collections.Generic;
using System.IO;
using EstacionamentoWEB.Models;

namespace EstacionamentoWEB.Repositorio
{
    public class EntradaRepositorio
    {
        private List<Entrada> entrada = new List<Entrada>();
        private string Path = "Database/Entrada.csv";
        public void Inserir(Entrada entrada) {
            try {
                if(!File.Exists(Path)) {
                    File.Create(Path).Close();
                }

                var linha = $"{entrada.Id};{entrada.Usuario};{entrada.Marca.Nome};{entrada.Modelo.Nome};{entrada.Placa.Nome};{entrada.DataEntrada}";

                File.AppendAllText(Path, linha + "\n");
                
            } catch(Exception e) {
                System.Console.WriteLine("Entrou no Catch");
                System.Console.WriteLine(e.StackTrace);
            }
        }
        public List<Entrada> ListarEntrada() {
            List<Entrada> listaDeEntradas = new List<Entrada>();

            string[] linhas = File.ReadAllLines("DataBase/Entrada.csv");
            Entrada entrada;

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty(item)) {
                    continue;
                }
                string[] linha = item.Split(";");
                entrada = new Entrada();
                entrada.Id = ulong.Parse(linha[0]);
                entrada.Usuario = linha[1];
                entrada.Marca.Nome = linha[2];
                entrada.Modelo.Nome = linha[3];
                entrada.Placa.Nome = linha[4];
                entrada.DataEntrada = DateTime.Parse(linha[5]);

                listaDeEntradas.Add(entrada);
            }
            return listaDeEntradas;
        }
    }
}