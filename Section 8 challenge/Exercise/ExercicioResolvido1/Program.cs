using System;
using Exercise.Entities;
using System.Collections.Generic;


namespace Exercise
{
    class Program
    {
        static void Main()
        {
            List<Employee> get = new List<Employee>();
            Console.Write("Enter the Number of employees: ");
            int qtd = int.Parse(Console.ReadLine());
            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Employees #{0} data", i);
                Console.Write("Outsourced(y/n)? ");
                string r = Console.ReadLine().ToLower();


                while(r.Length > 1 || r != "y" && r != "n")
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option!");
                    Console.Write("Outsourced(y/n)? ");
                    r = Console.ReadLine();
                }
                char ch = char.Parse(r);



                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Hours: ");
                int hor = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valorH = double.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double valorA = double.Parse(Console.ReadLine());
                    get.Add(new OutSourcedEmployees(nome, hor, valorH, valorA));
                }
                else
                {
                 
                    get.Add(new Employee(nome, hor, valorH));
                }
            }
            Console.Clear();
            Console.WriteLine("Payments: ");
            foreach(Employee emp in get)
            {
                Console.WriteLine($"\n{emp.Name} - ${emp.Payment()}");
            }
        }
    }
}