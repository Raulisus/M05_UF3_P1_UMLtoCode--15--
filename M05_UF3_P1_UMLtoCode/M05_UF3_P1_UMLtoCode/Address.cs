using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_P1_UMLtoCode
{
    internal struct Address
    {
        public string Street;
        public string City;
        public string State;
        public int PostalCode;
        public string Country;
        public Person Person;

        public bool Validate()
        {
            return true;
        }

    }
}
