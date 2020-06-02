using System;
using System.IO;

namespace H_arquivos.Aula02
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Teste();
        }*/

        static void Teste()
        {
            string userName = Environment.UserName;
            string path = @"C:\Users\" + userName + @"\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula02\file1.txt";
            
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}