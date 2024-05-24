using Store.Entities.Enums;
using Store.Entities;

namespace Store;

public class Program
{
    public static void Main(string[] args)
    {
        // Informações do cliente
        Console.WriteLine("Enter Client Data");
        Console.Write("Name: ");
        string clientName = Console.ReadLine() ?? "";
        Console.Write("Email: ");
        string clientEmail = Console.ReadLine() ?? "";
        Console.Write("Birth Date (DD/MM/YYYY): ");
        DateTime clientBirthDate = DateTime.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Enter Order Data:");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine() ?? "");

        Console.Write("How many items to this order: ");
        int numItems = int.Parse(Console.ReadLine() ?? "");

        Order order = new (
            DateTime.Now,
            status
        );

        for (int i = 1; i <= numItems; i++)
        {
            Console.WriteLine($"Enter #{i} item data:");
            Console.Write("Product Name: ");
            string productName = Console.ReadLine() ?? "";
            Console.Write("Product Price: ");
            double productPrice = double.Parse(Console.ReadLine() ?? "");
            Console.Write("Quantity: ");
            int productQuantity = int.Parse(Console.ReadLine() ?? "");

            OrderItem item = new (
                productQuantity,
                productPrice,
                new Product(productName, productPrice)
            );

            order.AddItem(item);
        }

        Client c1 = new (
            clientName,
            clientEmail,
            clientBirthDate,
            order
        );

        Console.WriteLine();
        Console.WriteLine(c1);
    }
}