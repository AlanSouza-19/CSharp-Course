using Store.Entities.Enums;
using Store.Entities;

namespace Store;

public class Program
{
    public static void Main(string[] args)
    {
        Product produto = new ("Tv", 1000.54);
        OrderItem item = new (3, 1000.54, produto);
        Order ordem1 = new (
            DateTime.Now,
            OrderStatus.Processing
        );

        ordem1.AddItem(item);

        Client c1 = new (
            "alan",
            "alan@gmail.com",
            DateTime.Today,
            ordem1
        );

        Console.WriteLine(c1);
    }
}