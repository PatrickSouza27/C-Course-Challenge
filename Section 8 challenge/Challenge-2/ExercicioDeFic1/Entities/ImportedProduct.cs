using System.Globalization;
namespace ExercicioDeFic1.Entities
{
    internal class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }


        public ImportedProduct(string name, double price, double customs) : base(name, price)
        {
            CustomsFee = customs;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }


        public override string PriceTag()
        {
            return ($"{Name}  ${TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs Fee: ${CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})");
        }

    }
}
