using System.Globalization;
using System.Net;
using TaxSystem.Entities;

namespace TaxSystem;
public class Program
{
    public static void Main(string[] args)
    {
        List<TaxPayer> taxPayers = [];

        Console.Write("Enter the number of tax payers: ");
        int numberOfTaxPayers = int.Parse(Console.ReadLine() ?? "");

        for (int i = 1; i <= numberOfTaxPayers; i++)
        {
            Console.WriteLine($"Tax payer #{i} data:");
            Console.Write("Individual or Company (i/c)? ");
            char response = char.Parse(Console.ReadLine() ?? "");

            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Annual income: ");
            double annualIncome = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);

            if (response == 'i')
            {
                Console.Write("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);

                taxPayers.Add(new Individual(name, annualIncome, healthExpenditures));
            } else if (response == 'c') {
                Console.Write("Number of employees: ");
                int numberOfEmployees = int.Parse(Console.ReadLine() ?? "");

                taxPayers.Add(new Company(name, annualIncome, numberOfEmployees));
            }
        }

        Console.WriteLine();

        Console.WriteLine("TAXES PAID:");
        double totalTax = 0.0;
        foreach (TaxPayer taxPayer in taxPayers)
        {
            totalTax += taxPayer.Tax();
            Console.WriteLine($"{taxPayer.Name}: R$ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
        }
        Console.WriteLine();
        Console.WriteLine($"TOTAL TAXES: R$ {totalTax.ToString("F2", CultureInfo.InvariantCulture)}");
    }    
}