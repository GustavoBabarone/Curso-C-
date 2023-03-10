using System;
using G.Heranca.Polimorfismo.Aula02.Entities;

namespace G.Heranca.Polimorfismo.Aula02
{
    public class Aula02
    {
        public static void Executar()
        {
            Conta conta = new Conta(1001, "Gustavo", 0.0);
            ContaSalario contaSalario1 = new ContaSalario(1002, "Alex", 0.0, 500.00);

            /* UPCASTING -> 'ContaSalario' é uma 'Conta' */
            Conta conta1 = contaSalario1;
            Conta conta2 = new ContaSalario(1003, "Bob", 0.0, 200.0);
            Conta conta3 = new ContaCorrente(1004, "Anna", 0.0, 0.01);

            /* DOWNCASTING ->  'Conta' não é uma 'ContaSalario' nem 'ContaCorrente' */
            ContaSalario contaSalario2 = (ContaSalario)conta2;
            contaSalario2.RealizarEmprestimo(100.0);

            /* ContaSalario contaSalarioErro = (ContaSalario) acc3; <- COMPILADOR NÃO PERCEBE O ERRO! COMO SOLUCIONAR? */
            if (conta3 is ContaSalario)
            {
                ContaSalario contaSalario3 = (ContaSalario)conta3;
                Console.WriteLine("Downcasting não será executado!");
            }

            if (conta3 is ContaCorrente)
            {
                /* ContaCorrente sacc1 = (ContaCorrente) acc3;*/
                ContaCorrente contaCorrente = conta3 as ContaCorrente;
                contaCorrente.AtualizarSaldo();
                Console.WriteLine("Saldo atualizado!");
            }
        }
    }
}