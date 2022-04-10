using System;
using System.Collections.Generic;
using System.Text;
using ExercicioProposto.Entities.Enums;
using System.Globalization;
namespace ExercicioProposto.Entities
{
    internal class Order
    {
        public DateTime Momento { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();
        public Order()
        {
        }
        public Order(DateTime momento, OrderStatus orderStatus, Client client)
        {
            Momento = momento;
            OrderStatus = orderStatus;
            Client = client;
        }
        public double ValorTotalOrder()
        {
            double soma = 0;
            foreach(OrderItem item in OrderItens)
            {
                soma += item.SubTotal();
            }
            return soma;
        }
        public void AddItens(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public void RemoveItens(OrderItem item)
        {
            OrderItens.Remove(item);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\n--------------------------------------\n" +
                $"ORDER SUMMARY:\nOrder moment:{Momento}\n" +
                $"Order status:{OrderStatus}\nClient: {Client}\nOrder items:\n");
            foreach(OrderItem it in OrderItens)
            {
                sb.AppendLine(it.ToString()+"-----------------------");
            }
            sb.Append($"Total price: ${ValorTotalOrder().ToString("F2",CultureInfo.InvariantCulture)}");
                return sb.ToString();
        }
    }
}
