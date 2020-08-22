using System;
using System.Collections.Generic;
using System.IO;

namespace J_Generics_set_dictionary.Exercicio01
{
    public class Program
    {
        static void Teste()
        {
            string userName = Environment.UserName;
            string path = @"C:\Users\" + userName + @"\Projects-Idea\Projects-Rider\Curso\J-Generics-set-dictionary\Exercicio01\arquivo.txt";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Arquivo não encontrado!");
            }
            
            Dictionary<string, int> votacao = new Dictionary<string, int>();
            
            StreamReader sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                var linha = sr.ReadLine();
                if (!String.IsNullOrEmpty(linha))
                {
                    var vetor = linha.Split(",");

                    if (!votacao.ContainsKey(vetor[0]))
                    {
                        votacao[vetor[0]] = 0;
                    }
                    votacao[vetor[0]] += int.Parse(vetor[1]);
                }
            }

            Console.WriteLine("\nResultado da votação:");
            foreach (var voto in votacao)
            {
                Console.WriteLine($"{voto.Key.PadRight(12)} teve {voto.Value} votos");
            }
        }
        
        /*static void Main(string[] args)
        {
            Teste();    
        }*/
    }
}