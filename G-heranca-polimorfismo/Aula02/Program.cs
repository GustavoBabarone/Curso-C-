using System;
using G_heranca_polimorfismo.Aula02.Entities;

namespace G_heranca_polimorfismo.Aula02
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Teste();
        }*/

        static void Teste()
        {
            Account acc = new Account(1001, "Gustavo", 0.0);
            BusinessAccount bacc1 = new BusinessAccount(1002, "Alex", 0.0, 500.00);
            
            /* UPCASTING -> 'bacc' é um 'acc' */
            Account acc1 = bacc1;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);
            
            /* DOWNCASTING ->  'acc' não é um 'bacc' */
            BusinessAccount bacc2 = (BusinessAccount) acc2;
            bacc2.Loan(100.0);

            /*BusinessAccount bacc3 = (BusinessAccount) acc3; <- COMPILADOR NÃO PERCEBE O ERRO! COMO SOLUCIONAR? */
            if (acc3 is BusinessAccount)
            {
                BusinessAccount bacc3 = (BusinessAccount) acc3;
                Console.WriteLine("Downcasting não será executado!");
            }
            
            if (acc3 is SavingAccount)
            {
                /*SavingAccount sacc1 = (SavingAccount) acc3;*/
                SavingAccount sacc1 = acc3 as SavingAccount;
                sacc1.UpdateBalance();
                Console.WriteLine("UpdateBalance executado!");
            }
        }
    }
}