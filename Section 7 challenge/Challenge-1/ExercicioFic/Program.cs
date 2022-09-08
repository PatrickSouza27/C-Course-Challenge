using System;
using ExercicioFic.Entities;
using ExercicioFic.Entities.Enums;
using System.Globalization;
namespace ExercicioFic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter cliente data:\n");
            //nome
            Console.Write("Name: ");
            string name = Console.ReadLine();

            //email
            Console.Write("Email: ");
            string email = Console.ReadLine();

            //Estou pegando a data de nascimento
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");

            //Estou pegando o horario que o pedido esta sendo feito
            DateTime momento = DateTime.Now;

            //aqui to convertendo a string para o tipo enumerado
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            //peguei as informações do cliente, agora preciso converter pro cliente construtor, q ta esperando o nome string, email string e data datetime
            Client clientConverct = new Client(name, email, date);
            Order cliente = new Order(momento, status, clientConverct);

            //quantidade de itens
            Console.Write("How many items to this order: ");
            int qtdItens = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtdItens; i++)
            {
                Console.WriteLine("\nEnter #{0} item data:", i);

                //pegando o nome do produto n
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                //pegando o preço do produto n
                Console.Write("Product Price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //pegando a quantidade desse produto n
                Console.Write("Quantity: ");
                int qtdProduct = int.Parse(Console.ReadLine());

                //aqui to convertendo as informações de cima pra forma de product para colocar na sobrecarga da OrderItem
                Product nameConvert = new Product(nameProduct);

                //colocando a qtd de produto, preço e nome
                OrderItem acess = new OrderItem(qtdProduct, priceProduct, nameConvert);

                //adicionando na lista
                cliente.AddItem(acess);
            }

            Console.WriteLine(cliente);

        }
    }
}
