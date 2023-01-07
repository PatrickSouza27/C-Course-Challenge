using ExercicioDeFic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
namespace Section11
{
    class Program
    {
        static void Main()
        {
            Produto x = new Produto();

            Console.WriteLine("Entre com a localização que deseja criar a pasta: ");
            string pasta = Console.ReadLine();
            try
            {
                Directory.CreateDirectory(pasta + @"\out");

                Console.WriteLine("Quantidade de Produtos: ");
                int qtd = int.Parse(Console.ReadLine());
                for (int i = 0; i < qtd; i++)
                {
                    string[] value = Console.ReadLine().Split(",");
                    x.Nome = value[0];
                    x.Price = double.Parse(value[1], CultureInfo.InvariantCulture);
                    x.Qtd = int.Parse(value[2]);

                    using (StreamWriter ArquivoGravar = File.AppendText(pasta + @"\out\summary.csv"))
                    {
                        ArquivoGravar.WriteLine(x.Nome + "," + x.Price.ToString("f2", CultureInfo.InvariantCulture) + "," + x.Qtd + "," + x.Total());
                    }
                    using (StreamWriter AtualizarGravar = File.AppendText(pasta + @"\Arquivo.txt"))
                    {
                        AtualizarGravar.WriteLine(x.Nome);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}