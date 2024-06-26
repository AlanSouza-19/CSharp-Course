﻿using Store.Entities.Enums;

namespace Store.Entities;
public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public Order(DateTime moment, OrderStatus status)
    {
        Moment = moment;
        Status = status;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        Items.Remove(item);
    }

    public double Total()
    {
        double total = 0.0;
        foreach (OrderItem item in Items)
        {
            total += item.SubTotal();
        }
        return total;
    }
}
