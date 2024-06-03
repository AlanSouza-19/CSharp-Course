namespace StockSystem;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of products: ");
        int numberOfProducs = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberOfProducs; i++ )
        {
            Console.WriteLine($"Product #{i} data:");
        }
    }
}
