using System.Globalization;
using StockSystem.Entites;

namespace StockSystem;
class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = [];

        Console.Write("Enter the number of products: ");
        int numberOfProducs = int.Parse(Console.ReadLine() ?? "");

        for (int i = 1; i <= numberOfProducs; i++ )
        {
            Console.WriteLine($"Product #{i} data:");
            Console.Write("Common, used or imported (c/u/i)? ");
            char response = char.Parse(Console.ReadLine() ?? "");
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);

            switch (response)
            {
                case 'c':
                    products.Add(new Product(name, price));
                    break;
                case 'u':
                    Console.Write("Manugacture date (DD/MM/YYYY): ");
                    string date = Console.ReadLine() ?? "";
                    products.Add(new UsedProduct(name, price, DateTime.Parse(date)));
                    break;
                case 'i':
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customFee));
                    break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Price Tags:");

        foreach (Product product in products)
        {
            Console.WriteLine(product.PriceTag());
        }
    }
}
