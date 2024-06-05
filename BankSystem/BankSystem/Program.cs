using System.Globalization;
using BankSystem.Entities;
using BankSystem.Entities.Exceptions;

namespace BankSystem;
class Program
{
    public static void Main(string[] args)
    {
        try {
            Account acc;

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Holder: ");
            string holder = Console.ReadLine() ?? "";
            Console.Write("Inicial balance: ");
            double deposit = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);

            acc = new Account(number, holder, deposit, withdrawLimit);

            Console.Write("Enter the amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);

            acc.WithDraw(withdraw);

            Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
        } catch (WithDrawException e) {
            Console.WriteLine("Withdraw exception: " + e.Message);
        }
    }
}