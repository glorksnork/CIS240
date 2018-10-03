using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank._1
{
    class Account1
    {
        //Instance Variable
        private readonly string name;
        private decimal balance;

        public Account1(string accName, decimal acctBalance = 0)
        {
            name = accName;
            balance = acctBalance;
        }
        public string GetName()
        {
            return name;
        }

        public decimal GetBalance()
        {
            return balance;
        }
        private void SetBalance(decimal amt)
        {
            balance = amt;
        }

        

        override public string ToString()
        {
            return $"Account: {name} / Balance = {balance:C}";
        }
    }
}
