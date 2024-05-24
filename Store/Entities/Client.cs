using System.Globalization;
using System.Text;

namespace Store.Entities;

public class Client
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public Order Order { get; set; } // Em um sistema real talvez o melhor seria cada cliente ter uma lista de ordem

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
        b1.AppendLine("ORDER SUMMARY:");
        b1.AppendLine($"Order moment: {Order.Moment}");
        b1.AppendLine($"Order status: {Order.Status}");
        b1.Append("Client: ");
        b1.Append(Name);
        b1.Append(' ');
        b1.Append($"({BirthDate.ToString("dd/MM/yyyy")})");
        b1.Append(" - ");
        b1.AppendLine(Email);
        b1.AppendLine("Order items:");

        foreach (OrderItem item in Order.Items)
        {
            b1.Append($"{item.Product.Name}, ");
            b1.Append(
                $"R$ {item.Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
            b1.Append($"Quantity: {item.Quantity}, ");
            b1.AppendLine($"Subtotal: R$ {item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
        b1.Append("Total price: ");
        b1.Append($"R$ {Order.Total().ToString("F2", CultureInfo.InvariantCulture)}");

        return b1.ToString();
    }
}
