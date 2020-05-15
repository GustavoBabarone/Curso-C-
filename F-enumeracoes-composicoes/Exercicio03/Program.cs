using System;
using System.Globalization;
using F_enumeracoes_composicoes.Exercicio03.Entities;
using F_enumeracoes_composicoes.Exercicio03.Entities.Enums;

namespace F_enumeracoes_composicoes.Exercicio03
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Teste();
        }*/

        static void Teste()
        {
            Console.WriteLine("Enter cliente data:");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter order data: ");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            Client client = new Client(name, email, birthDate);
            Order order = new Order(status, client);
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter #{i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                
                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(item);
            }
            Console.WriteLine(order);
        }
    }
}