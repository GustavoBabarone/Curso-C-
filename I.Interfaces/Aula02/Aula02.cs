using System;
using I.Interfaces.Aula02.Entities;

namespace I.Interfaces.Aula02
{
    public class Aula02
    {
        public static void Executar()
        {
            IForma f1 = new Circulo { Raio = 2.0, Cor = Cor.Branco };
            IForma f2 = new Retangulo { Comprimento = 3.5, Altura = 4.2, Cor = Cor.Preto };

            Console.WriteLine(f1);
            Console.WriteLine(f2);
        }
    }
}