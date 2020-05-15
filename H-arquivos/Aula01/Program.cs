using System;
using System.IO;

namespace H_arquivos.Aula01
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Teste();
        }*/

        static void Teste()
        {
            string sourcePath = @"C:\Users\gustavo.bruder\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula01\file1.txt";
            string targetPath = @"C:\Users\gustavo.bruder\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula01\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
        }
    }
}