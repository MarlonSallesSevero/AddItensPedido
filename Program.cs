using System;
using ExercicioProposto.Entities;
using ExercicioProposto.Entities.Enums;

namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name:");
            string nome = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY):");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Client cliente1 = new Client(nome, email, data);
            Console.WriteLine("Enter order data:");
            Console.Write("0 - PagamentoPendente\n1 - Processando\n2 - Enviado\n3 - Entregue\n");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Order pedido1 = new Order(DateTime.Now, status, cliente1);
            Console.Write("How many itens to this order?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name:");
                string prodNome = Console.ReadLine();
                Console.Write("Product price:");
                double prodPrice = double.Parse(Console.ReadLine());
                Product produto = new Product(prodNome, prodPrice);
                Console.Write("Quantity:");
                int prodQuant = int.Parse(Console.ReadLine());
                OrderItem pedidoItens = new OrderItem(produto, prodQuant);
                Console.WriteLine("----------------------------");
                double total = pedidoItens.SubTotal();
                pedidoItens.Total = total;
                pedido1.AddItens(pedidoItens);
            }
            Console.WriteLine(pedido1);
            string a = Console.ReadLine();
        }
    }
}
