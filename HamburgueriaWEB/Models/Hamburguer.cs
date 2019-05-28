using Microsoft.Extensions.Primitives;

namespace Hamburgueria_Manha.Models
{
    public class Hamburguer : Produto
    {

        public Hamburguer()
        {

        }
        
        public Hamburguer(string Nome)
        {
            this.Nome = Nome;
        }
    }
}