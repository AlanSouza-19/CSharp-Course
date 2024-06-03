using System.Text;
using System.Globalization;

namespace StockSystem.Entites;
public class UsedProduct : Product
{
    public DateTime ManufactureDate { get; set; }

    public UsedProduct(string name, double price, DateTime manufactureDate)
        : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }

    public override string PriceTag()
    {
        StringBuilder sb = new ();

        sb.Append($"Name (used)");
        sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
        sb.Append($"(Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})");

        return sb.ToString();
    }
}
