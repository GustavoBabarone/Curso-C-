using System;
using System.IO;

namespace H_arquivos.Aula04
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Teste();
        }*/

        static void Teste()
        {
            string sourcePath = @"C:\Users\gustavo.bruder\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula04\file1.txt";
            string targetPath = @"C:\Users\gustavo.bruder\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula04\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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