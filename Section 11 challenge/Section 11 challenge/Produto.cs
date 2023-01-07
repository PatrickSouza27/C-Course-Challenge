using System.IO;
using System.Globalization;
namespace Section11
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Price { get; set; }
        public int Qtd { get; set; }

        public Produto()
        {

        }
        public Produto(string nome, double price, int qtd)
        {
            Nome = nome;
            Price = price;
            Qtd = qtd;
        }
        public double Total()
        {
            return Price * Qtd;
        }

    }
}
