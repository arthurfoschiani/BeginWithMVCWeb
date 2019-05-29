using System;

namespace EstacionamentoWEB.Models
{
    public class Entrada
    {
        public ulong Id;
        public string Usuario;
        public Marca Marca;
        public Modelo Modelo;
        public Placa Placa;
        public DateTime DataEntrada;
    }
}