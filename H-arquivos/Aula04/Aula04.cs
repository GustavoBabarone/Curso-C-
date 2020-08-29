using System;
using System.IO;

namespace H_arquivos.Aula04
{
    public class Aula04
    {
        public static void Executar()
        {
            string usuario = Environment.UserName;
            string diretorioEntrada = @"C:\Users\" + usuario + @"\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula04\arquivo1.txt";
            string diretorioSaida = @"C:\Users\" + usuario + @"\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula04\arquivo2.txt";

            try
            {
                string[] linhas = File.ReadAllLines(diretorioEntrada);

                using (StreamWriter sw = File.AppendText(diretorioSaida))
                {
                    foreach (string linha in linhas)
                    {
                        sw.WriteLine(linha.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
        }
    }
}