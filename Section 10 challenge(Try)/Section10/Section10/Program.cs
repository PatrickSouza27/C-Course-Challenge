using System;
using System.Globalization;

namespace Section10
{
    class Program
    {
        static void Main()
        {
            Account User = new();

            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                User = new Account(number, holder, balance, limit);

                Console.Write("Enter amount for withdraw: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                User.Withdraw(value);

                Console.WriteLine(User);
            }
            catch(AccountException e)
            {
                Console.WriteLine(e.Message);
            }catch(FormatException)
            {
                Console.WriteLine("Formato Incorreto");
            }
        }
    }
}
