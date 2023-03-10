using System;

namespace D.Memoria.Arrays.Listas.Exercicio01
{
    public class Exercicio01
    {
        public static void Executar()
        {
            Estudante[] estudantes = new Estudante[10];

            Console.Write("Quantos quartos sarão alugados? ");
            int quartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quartos; i++)
            {
                Console.WriteLine($"Estudante {i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                estudantes[quarto - 1] = new Estudante(nome, email, quarto);
            }

            for (int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine($"Quarto {i + 1}: {estudantes[i].Nome}, {estudantes[i].Email}");
                }
            }
        }
    }
}