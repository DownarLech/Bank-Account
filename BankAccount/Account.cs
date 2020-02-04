using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Account
    {

        //private int idAccount;
        //private double balance;
        //private string nameOwner;

        public int IdAccount { get; set; }
        public double Balance { get; set; }
        public string NameOwner { get; set; }


        //konstruktor
        public Account(int idAccount, double balance, string nameOwner)
        {
            this.IdAccount = idAccount;
            this.Balance = balance;
            this.NameOwner = nameOwner;
        }


        //event and delegate
        public delegate bool SomeDelegate(double amount);
        public event SomeDelegate SomeEvent;


        public bool RaiseEvent(double amount)
        {
            if (SomeEvent != null)
            {
                SomeEvent.Invoke(amount);
                return true;
            }
            return false;
        }


        //deposit and withdraw
        public bool Deposit(double amount)
        {

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            Balance += amount;
            Console.WriteLine("Deposit is successful");
            return true;
        }

        public bool Withdraw(double amount)
        {


            if (amount <= 0)
            {

                RaiseEvent(amount);
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            if (Balance - amount < 0)
            {
                RaiseEvent(amount);
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            Balance -= amount;
            Console.WriteLine("Withdraw is successful");
            return true;
        }

        public void InfoClass()
        {
            Console.WriteLine(NameOwner + " " + Balance);
        }
    }
}
