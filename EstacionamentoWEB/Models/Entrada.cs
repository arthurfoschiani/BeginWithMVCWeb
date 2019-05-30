using System;

namespace EstacionamentoWEB.Models
{
    public class Entrada
    {
        public int Id {get;set;}
        public string Usuario {get;set;}
        public string Marca {get;set;}
        public string Modelo {get;set;}
        public string Placa {get;set;}
        public DateTime DataEntrada {get;set;}
    }
}