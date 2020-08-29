using System;
using System.IO;

namespace H_arquivos.Aula03
{
    public class Aula03
    {
        public static void Executar()
        {
            string usuario = Environment.UserName;
            string diretorio = @"C:\Users\" + usuario + @"\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula03\arquivo1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(diretorio))
                {
                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        Console.WriteLine(linha);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
        }
    }
}