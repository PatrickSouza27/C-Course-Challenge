using System.Globalization;
namespace ExercicioFic.Entities
{
    internal class OrderItem
    {
        public int Quantidade { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }
        public OrderItem(int quantidade, double price, Product product)
        {
            Quantidade = quantidade;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantidade * Price;
        }
        public override string ToString()
        {
            return ($"{Product.Name}, ${Price.ToString("f2", CultureInfo.InvariantCulture)}, Quantity: {Quantidade}, SubTotal: {SubTotal().ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}
