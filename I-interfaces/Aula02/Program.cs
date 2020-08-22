using System;
using I_interfaces.Aula02.Entities;

namespace I_interfaces.Aula02
{
    public class Program
    {
        static void Teste()
        {
            IForma f1 = new Circulo { Raio = 2.0, Cor = Cor.Branco};
            IForma f2 = new Retangulo { Comprimento = 3.5, Altura = 4.2, Cor = Cor.Preto};
            
            Console.WriteLine(f1);
            Console.WriteLine(f2);
        }
        
        /*static void Main(string[] args)
        {
            Teste();
        }*/
    }
}