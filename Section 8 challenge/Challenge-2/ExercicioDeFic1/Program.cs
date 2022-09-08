using System;
using ExercicioDeFic1.Entities;
using System.Collections.Generic;
using System.Globalization;


namespace ExerFic {
    class Program
    {
        static void Main()
        {
            List<Product> lista = new List<Product>();

            Console.Write("Enter the Number OF Product: ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("\nProduct #{0} data: ", i);
                Console.Write("Common, used or imported: (c/u/i): ");
                string valid = Console.ReadLine().ToLower();
                while(valid.Length != 1 || valid != "c" && valid != "u" && valid != "i")
                {
                    Console.Clear();
                    Console.WriteLine("incorrect option!");
                    Console.Write("Common, used or imported: (c/u/i): ");
                    valid = Console.ReadLine().ToLower();
                }
                char opc = char.Parse(valid);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(opc == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ImportedProduct(name, price, fee));
                }else if(opc == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    lista.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    lista.Add(new Product(name, price));
                }
               
            }
            Console.WriteLine("\nPRICE TAGS: ");
            foreach(Product p in lista)
            {
                Console.WriteLine("{0}", p.PriceTag());
            }
        }
    }
}
