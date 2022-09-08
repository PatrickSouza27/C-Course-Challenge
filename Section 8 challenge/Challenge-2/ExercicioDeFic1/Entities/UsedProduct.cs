using System.Globalization;
namespace ExercicioDeFic1.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            Date = date;
        }
        public override string PriceTag()
        {
            return ($"{Name} (Used) $ {Price.ToString("F2")} (Manufacture date: {Date.ToString("dd/MM/yyyy")})");
        }
    }
}
