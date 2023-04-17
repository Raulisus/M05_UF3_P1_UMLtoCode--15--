using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_P1_UMLtoCode
{
    internal struct Transaction
    {
        public string From;
        public string To;
        public float Amount;
        public DateTime Request;
        public Account Account;
    }
}
