namespace ExercicioFic.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name)
        {
            Name = name;
        }
        
        public void PriceAss(OrderItem value)
        {
            Price = value.Price;
        }
    }
}
