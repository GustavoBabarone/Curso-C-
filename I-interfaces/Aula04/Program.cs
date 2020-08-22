using System;
using System.Collections.Generic;
using System.IO;
using I_interfaces.Aula04.Entities;

namespace I_interfaces.Aula04
{
    public class Program
    {
        static void Teste()
        {
            var userName = Environment.UserName;
            var path = $@"C:\Users\{userName}\temp-teste\arquivo01.txt";

            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    var lista = new List<Funcionario>();
                    while (!reader.EndOfStream)
                    {
                        lista.Add(new Funcionario(reader.ReadLine()));
                    }
                    
                    lista.Sort();

                    Console.WriteLine("Funcionários:");
                    foreach (var funcionario in lista)
                    {
                        Console.WriteLine(funcionario);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {e.Message}");
            }
        }
        
        /*static void Main(string[] args)
        {
            Teste();    
        }*/
    }
}