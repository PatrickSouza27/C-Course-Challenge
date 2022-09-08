using System;
using System.Collections.Generic;
using ExercicioDeFic.Entities;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main()
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Enter the Number of tax payers: ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("\nTax payer #{0} data: ", i);
                Console.Write("Individual or companu (i/c)? ");
                string valid = Console.ReadLine().ToLower();
                while(valid.Length != 1 || valid != "i" && valid != "c")
                {
                    Console.Clear();
                    Console.WriteLine("invalid option!");
                    Console.Write("Individual or companu (i/c)? ");
                    valid = Console.ReadLine().ToLower();
                }
                char opc = char.Parse(valid);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(opc == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double valueHealth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(name, value, valueHealth));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Pessoajuridica(name, value, numberEmployees));
                }
            }
            Console.WriteLine("\nTAXES PAID: ");
            foreach(Pessoa x in list)
            {
                Console.WriteLine($"{x.Nome}: ${x.CalcImposto().ToString("f2", CultureInfo.InvariantCulture)}");
            }
            double sumTotTaxes = 0.0;
            foreach(Pessoa x in list)
            {
                sumTotTaxes += x.CalcImposto();
            }
            Console.WriteLine("\nTOTAL TAXES: $ {0}", sumTotTaxes.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
