using System.Globalization;
namespace Section10
{
    internal class Account
    {
        public int Number { get; private set; }
        public string? Holder { get; set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; private set; }

        public Account()
        {

        }

        public Account(int number, string? holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            if (balance < 0 || withDrawLimit < 0)
            {
                throw new AccountException("Valor Invalido!");
            }
            else
            {
                Balance = balance;
                WithDrawLimit = withDrawLimit;
            }
        }

        public void Deposit(double deposit)
        {
            Balance += deposit;
        }
        public void Withdraw(double withdraw)
        {
            if(withdraw > Balance || Balance == 0)
            {
                throw new AccountException("Error: the withdrawal is greater than your balance! ");
            }if(withdraw > WithDrawLimit)
            {
                throw new AccountException("Error: You are tryng withdraw an amount greater than your limit! ");
            }
            Balance -= withdraw;
        }

        public override string ToString()
        {
            return ($"New Balance: {Balance.ToString("f2", CultureInfo.InvariantCulture)}");
        }

    }
}
