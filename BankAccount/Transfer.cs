using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Transfer
    {
        public static void MakeTransfer(Account source, Account destination, int amount)
        {
            source.Withdraw(amount);
            destination.Deposit(amount);
            Console.WriteLine("Transfer was successful");
        }

    }
}
