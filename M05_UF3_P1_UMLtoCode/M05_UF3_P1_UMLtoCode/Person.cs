using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace M05_UF3_P1_UMLtoCode
{
    internal abstract class Person
    {
        public int ID;
        public string Name;
        protected string Phone;
        public string Email;
        public Address address;
    }
}
