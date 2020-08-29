using System;
using System.IO;

namespace H_arquivos.Aula02
{
    public class Aula02
    {
        public static void Executar()
        {
            string usuario = Environment.UserName;
            string diretorio = @"C:\Users\" + usuario + @"\Projects-Idea\Projects-Rider\Curso\H-arquivos\Aula02\arquivo1.txt";
            
            StreamReader stream = null;

            try
            {
                stream = File.OpenText(diretorio);

                while (!stream.EndOfStream)
                {
                    string linha = stream.ReadLine();
                    Console.WriteLine(linha);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }
    }
}