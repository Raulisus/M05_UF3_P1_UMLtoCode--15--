using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace M05_UF3_P1_UMLtoCode
{
    internal class Account
    {
        public string IBAN;
        protected float Amount;
        public Customer Customer;
        public Transaction trs;

        public bool Transaction(string param)
        {
            return true;
        }
    }
}
