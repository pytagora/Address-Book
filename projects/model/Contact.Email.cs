using System;
using System.Collections;

namespace Model
{
    public partial class Contact
    {
        public class Email
        {
            public string Address { get; set; }
            public Email(string address)
            {
                Address = address;
            }
        }
    }
}