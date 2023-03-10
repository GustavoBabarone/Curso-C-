namespace D.Memoria.Arrays.Listas.Aula01
{
    public class Aula01
    {
        public static void Executar()
        {
            Pessoa p1, p2;
            p1 = new Pessoa("Gustavo", 17);
            p2 = p1;

            /* p2 apenas aponta para onde p1 aponta na memória => heap */

            double n1, n2;
            n1 = 10;
            n2 = n1;

            /* n2 copia valor de n1 - n2 NÃO aponta para o mesmo lugar de n1 => stack */
        }
    }
}