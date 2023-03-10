using System;
using System.IO;

namespace H.Arquivos.Aula01
{
    public class Aula01
    {
        public static void Executar()
        {
            string usuario = Environment.UserName;
            string diretorioEntrada = @"C:\Users\" + usuario +
                                      @"\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula01\arquivo-entrada.txt";
            string diretorioSaida = @"C:\Users\" + usuario +
                                    @"\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula01\arquivo-saida.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(diretorioEntrada);
                fileInfo.CopyTo(diretorioSaida);

                string[] linhas = File.ReadAllLines(diretorioEntrada);
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
        }
    }
}