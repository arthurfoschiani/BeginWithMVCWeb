using System.Collections.Generic;
using System.IO;
using Hamburgueria_Manha.Models;

namespace Hamburgueria_Manha.Repositorios
{
    public class ShakeRepositorio
    {
        private const string PATH = "Database/Shake.csv";
        private List<Shake> Shakes = new List<Shake>();

        public List<Shake> Listar() 
        {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Shake shake = new Shake();
                shake.Nome = valores[1];
                shake.Preco = double.Parse(valores[2]);

                this.Shakes.Add(shake);
            }
            return this.Shakes;
        }
    }
}