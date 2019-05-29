using System.Collections.Generic;
using System.IO;
using EstacionamentoWEB.Models;

namespace EstacionamentoWEB.Repositorio
{
    public class MarcaRepositorio
    {
        private const string PATH = "Database/Marca.csv";
        private List<Marca> Marcas = new List<Marca>();
        public List<Marca> Listar() {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros) {
                var valores = item.Split(";");
                Marca marca = new Marca();
                marca.Nome = valores[1];

                this.Marcas.Add(marca);
            }
            return this.Marcas;
        }
        public double ObterId(string nomeMarca) {
            var lista = Listar();
            var idCarro = 0;

            foreach (var item in lista) {
                if (item.Nome.Equals(nomeMarca)) {
                    idCarro = item.IdCarro;
                }
            }
            return idCarro;
        }
    }
}