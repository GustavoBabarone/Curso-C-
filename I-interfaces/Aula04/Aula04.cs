using System;
using System.Collections.Generic;
using System.IO;
using I_interfaces.Aula04.Entities;

namespace I_interfaces.Aula04
{
    public class Aula04
    {
        public static void Executar()
        {
            var usuario = Environment.UserName;
            var diretorio = $@"C:\Users\{usuario}\Projects-Idea\Projects-Rider\Curso\I-interfaces\Aula04\arquivo.txt";

            try
            {
                using (StreamReader reader = File.OpenText(diretorio))
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
    }
}