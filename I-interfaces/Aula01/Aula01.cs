using System;
using System.Globalization;
using I_interfaces.Aula01.Entities;
using I_interfaces.Aula01.Services;

namespace I_interfaces.Aula01
{
    public class Aula01
    {
        public static void Executar()
        {
            Console.WriteLine("Insira os dados do aluguel: ");
            
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();
            
            Console.Write("Inicio (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            
            Console.Write("Retorno (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            
            Console.Write("Insira preço por hora: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Insira o preço por dia: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            
            rentalService.ProcessInvoice(carRental);
            
            Console.WriteLine("Fatura final: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}