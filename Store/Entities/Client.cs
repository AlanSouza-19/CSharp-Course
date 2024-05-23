using System.Globalization;
using System.Text;

namespace Store.Entities;

public class Client
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public Order Order { get; set; }

    public Client(string name, string email, DateTime birthDate, Order order)
    {
        Name = name;
        Email = email;
        BirthDate = birthDate;
        Order = order;
    }

    public override string ToString()
    {
        StringBuilder b1 = new StringBuilder();
        b1.AppendLine(Order.Moment.ToString());
        b1.AppendLine(Order.Status.ToString());
        b1.Append(Name);
        b1.Append(" ");
        b1.Append("("+BirthDate+")");
        b1.Append(" ");
        b1.Append(Email);

        foreach (OrderItem item in Order.OrderItems)
        {
            b1.AppendLine($"{item.Product.Name}, R$ {item.Price}, {item.SubTotal()}");
        }
        b1.AppendLine(Order.Total().ToString("F2", CultureInfo.InvariantCulture));

        return b1.ToString();
    }
}
