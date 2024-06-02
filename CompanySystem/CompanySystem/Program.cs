using System.Globalization;
using CompanySystem.Entities;

namespace CompanySystem;
class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = [];
        Console.Write("Enter the number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine() ?? "");

        for (int i = 1; i <= numberOfEmployees; i++)
        {
            Console.WriteLine($"Employee #{i} data:");
            Console.Write("Outsourced (y/n)? ");
            char response = char.Parse(Console.ReadLine() ?? "");
            bool isOutsourced = response == 'y';

            if (isOutsourced)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine() ?? "";
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine() ?? "");
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
                Console.Write("Addicional charge: ");
                double addicionalCharge = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);

                employees.Add(new OutsourceEmployee(
                    name,
                    hours,
                    valuePerHour,
                    addicionalCharge
                ));

            } else {
                Console.Write("Name: ");
                string name = Console.ReadLine() ?? "";
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine() ?? "");
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);

                employees.Add(new Employee(
                    name,
                    hours,
                    valuePerHour
                ));
            }    
        }

        Console.WriteLine();
        Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(
                    $"{employee.Name} - " +
                    $"R$ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}"
                );
            }
    }
}