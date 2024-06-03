using System.Globalization;
using System.Text;

namespace StockSystem.Entites;

public class ImportedProduct : Product
{
    public double CustomFee { get; set; }

    public ImportedProduct(string name, double price, double customFee)
        : base(name, price)
    {
        CustomFee = customFee;
    }

    public override string PriceTag()
    {
        StringBuilder sb = new ();

        sb.Append(Name);
        sb.Append((Price+CustomFee).ToString("F2", CultureInfo.InvariantCulture));
        sb.Append($"(Customs fee: R$ {Price.ToString("F2", CultureInfo.InvariantCulture)})");

        return sb.ToString();
    }
}
