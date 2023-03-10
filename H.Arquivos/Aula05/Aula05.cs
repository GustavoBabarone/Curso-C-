using System;
using System.Collections.Generic;
using System.IO;

namespace H.Arquivos.Aula05
{
    public class Aula05
    {
        public static void Executar()
        {
            string usuario = Environment.UserName;
            string diretorio = @"C:\Users\" + usuario + @"\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula05";

            try
            {
                IEnumerable<string> pastas =
                    Directory.EnumerateDirectories(diretorio, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("PASTAS:");
                foreach (string pasta in pastas)
                {
                    Console.WriteLine(pasta);
                }

                Console.WriteLine("----------------------------------------");

                IEnumerable<string> arquivos = Directory.EnumerateFiles(diretorio, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("ARQUIVOS:");
                foreach (string arquivo in arquivos)
                {
                    Console.WriteLine(arquivo);
                }

                Console.WriteLine("----------------------------------------");
                Directory.CreateDirectory(diretorio + @"\newFolder");
                Console.WriteLine("Nova pasta criada!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro! " + e);
            }
        }
    }
}