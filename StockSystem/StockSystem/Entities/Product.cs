using System.Globalization;
using System.Text;

namespace StockSystem.Entites;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual string PriceTag()
    {
        StringBuilder sb = new ();

        sb.Append(Name);
        sb.Append(" R$ ");
        sb.Append(Price.ToString("F2", CultureInfo.InstalledUICulture));

        return sb.ToString();
    }
}
