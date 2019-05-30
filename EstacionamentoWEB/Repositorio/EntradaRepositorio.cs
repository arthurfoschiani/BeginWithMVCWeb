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
            if (File.Exists ("DataBase/Entrada.csv")) {
                entrada.Id = File.ReadAllLines ("DataBase/Entrada.csv").Length + 1;

            } else {
                entrada.Id = 1;
            }
            try {
                if(!File.Exists(Path)) {
                    File.Create(Path).Close();
                }

                var linha = $"{entrada.Id};{entrada.Usuario};{entrada.Marca};{entrada.Modelo};{entrada.Placa};{entrada.DataEntrada}";

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
                entrada.Id = int.Parse(linha[0]);
                entrada.Usuario = linha[1];
                entrada.Marca = linha[2];
                entrada.Modelo = linha[3];
                entrada.Placa = linha[4];
                entrada.DataEntrada = DateTime.Parse(linha[5]);

                listaDeEntradas.Add(entrada);
            }
            return listaDeEntradas;
        }
    }
}