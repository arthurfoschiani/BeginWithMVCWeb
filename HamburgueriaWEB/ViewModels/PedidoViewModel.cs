using System.Collections.Generic;
using HamburgueriaWEB.Models;

namespace HamburgueriaWEB.ViewModels
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shakes {get;set;}
    }
}