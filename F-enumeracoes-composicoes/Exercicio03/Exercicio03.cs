using System;
using System.Globalization;
using F_enumeracoes_composicoes.Exercicio03.Entities;
using F_enumeracoes_composicoes.Exercicio03.Entities.Enums;

namespace F_enumeracoes_composicoes.Exercicio03
{
    public class Exercicio03
    {
        // TODO - Traduzir para portugues as classes, atributos, metodos e outras variaveis
        public static void Executar()
        {
            Console.WriteLine("Insira os dados do cliente:");
            
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            
            Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Console.Write("Nascimento (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nInsita os dados do pedido: ");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Console.Write("Quantos itens para esse pedido? ");
            int n = int.Parse(Console.ReadLine());
            
            Client client = new Client(name, email, birthDate);
            Order order = new Order(status, client);
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nInsira os dados do #{i+1} item:");
                Console.Write("Nome produto: ");
                string productName = Console.ReadLine();
                
                Console.Write("Preço produto: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Quantidade: ");
                int productQuantity = int.Parse(Console.ReadLine());
                
                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(item);
            }
            Console.WriteLine(order);
        }
    }
}