using System;
using System.Collections.Generic;
using System.IO;

namespace J_Generics_set_dictionary.Exercicio01
{
    public class Exercicio01
    {
        public static void Executar()
        {
            string usuario = Environment.UserName;
            string diretorio = @"C:\Users\" + usuario + @"\Projects-Idea\Projects-Rider\Curso\J-Generics-set-dictionary\Exercicio01\arquivo.txt";

            if (!File.Exists(diretorio))
            {
                throw new FileNotFoundException("Arquivo não encontrado!");
            }
            
            Dictionary<string, int> votacao = new Dictionary<string, int>();
            
            StreamReader sr = File.OpenText(diretorio);
            while (!sr.EndOfStream)
            {
                var linha = sr.ReadLine();
                if (!string.IsNullOrEmpty(linha))
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
    }
}