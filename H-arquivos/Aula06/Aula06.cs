using System;
using System.IO;

namespace H_arquivos.Aula06
{
    public class Aula06
    {
        public static void Executar()
        {
            string usuario = Environment.UserName;
            string diretorio = @"C:\Users\" + usuario + @"\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula06\file1.txt";
            
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(diretorio));
            Console.WriteLine("GetFileName: " + Path.GetFileName(diretorio));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(diretorio));
            Console.WriteLine("GetExtension: " + Path.GetExtension(diretorio));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(diretorio));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}