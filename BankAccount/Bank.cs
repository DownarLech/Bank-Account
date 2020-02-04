using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Bank
    {
        private string nameOfBank;
        private List<Account> listaAccounts;

        public string NameOfBank { get => nameOfBank; set => nameOfBank = value; }
        internal List<Account> ListaAccounts { get => listaAccounts; }

        public Bank(string nameOfBank)
        {
            this.nameOfBank = nameOfBank;
            this.listaAccounts = new List<Account>();
        }

    }
}
