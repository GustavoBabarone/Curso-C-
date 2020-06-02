using System;
using System.Collections.Generic;
using System.IO;

namespace H_arquivos.Aula05
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
            string path = @"C:\Users\" + userName + @"\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula05";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }
                
                Console.WriteLine("----------------------------------------");
                
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILES:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Console.WriteLine("----------------------------------------");
                Directory.CreateDirectory(path + @"\newFolder");
                Console.WriteLine("New folder created!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro! " + e);
            }
        }
    }
}