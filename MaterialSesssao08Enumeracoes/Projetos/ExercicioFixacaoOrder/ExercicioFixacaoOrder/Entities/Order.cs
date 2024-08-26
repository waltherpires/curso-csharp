﻿using ExercicioFixacaoOrder.Entities.Enums;
using System;
using System.Text;
using System.Globalization;

namespace ExercicioFixacaoOrder.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } 
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client; 
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
