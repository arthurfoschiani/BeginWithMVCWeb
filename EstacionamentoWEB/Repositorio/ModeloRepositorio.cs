using System.Collections.Generic;
using System.IO;
using EstacionamentoWEB.Models;

namespace EstacionamentoWEB.Repositorio
{
    public class ModeloRepositorio
    {
        private const string PATH = "Database/Modelo.csv";
        private List<Modelo> Modelos = new List<Modelo>();
        public List<Modelo> Listar() {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros) {
                var valores = item.Split(";");
                Modelo modelo = new Modelo();
                modelo.Nome = valores[1];
                this.Modelos.Add(modelo);
            }
            return this.Modelos;
        }
        public double ObterId(string nomeModelo) {
            var lista = Listar();
            var idCarro = 0;

            foreach (var item in lista) {
                if (item.Nome.Equals(nomeModelo)) {
                    idCarro = item.IdCarro;
                }
            }
            return idCarro;
        }
    }
}