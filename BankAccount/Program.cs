using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)

        {
            bool InfoEvent(double amount)
            {
                Console.WriteLine("Zdarzenie wystapiła dla kwoty: {0}", amount);
                Console.ReadKey();
                return true;
            }

            Account firstAccount = new Account(1, 150, "Smith");

            firstAccount.SomeEvent += new Account.SomeDelegate(InfoEvent);

            firstAccount.Deposit(100);
            firstAccount.InfoClass();
            firstAccount.Withdraw(100);
            firstAccount.InfoClass();

            //żeby zobaczyć działenie Event odkomentuj 2 wiersze poniżej
            //firstAccount.Withdraw(300);     
            //Console.ReadKey();

            Bank bankOne = new Bank("PostBank");
            bankOne.ListaAccounts.Add(new Account(1, 250, "Nowak"));

            Bank bankTwo = new Bank("CommerzBank");
            bankTwo.ListaAccounts.Add(new Account(1, 250, "Kowalski"));

            Transfer.MakeTransfer(bankOne.ListaAccounts[0], bankTwo.ListaAccounts[0], 100);

            bankOne.ListaAccounts[0].InfoClass();
            bankTwo.ListaAccounts[0].InfoClass();
            Console.ReadKey();
        }
    }
}
