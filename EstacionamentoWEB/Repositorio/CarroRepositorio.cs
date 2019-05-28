using System;
using System.Collections.Generic;
using System.IO;
using EstacionamentoWEB.Models;

namespace EstacionamentoWEB.Repositorio
{
    public class CarroRepositorio
    {
        public CarroModel CadastrarRegistro (CarroModel carro) {

            if (File.Exists ("registros.csv")) {
                carro.Id = File.ReadAllLines ("registros.csv").Length + 1;
            } else {
                carro.Id = 1;
            }

            StreamWriter SW = new StreamWriter ("registros.csv", true);
            SW.WriteLine ($"{carro.Id};{carro.NomeUsuario};{carro.Modelo};{carro.Marca};{carro.Placa};{carro.MomentoDaEntrada}");
            SW.Close ();
            return carro;
        }
        public List<CarroModel> ListarCarros() {
            List<CarroModel> listaDeCarros = new List<CarroModel>();

            string[] linhas = File.ReadAllLines("registros.csv");
            CarroModel carro;

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty(item)) {
                    continue;
                }
                string[] linha = item.Split(";");
                carro = new CarroModel(
                    id: int.Parse(linha[0]),
                    nomeUsuario: linha[1],
                    modelo: linha[2],
                    marca: linha[3],
                    placa: linha[4],
                    momentoDaEntrada: DateTime.Parse(linha[5])
                );
                listaDeCarros.Add(carro);
            }
            return listaDeCarros;
        }
    }
}