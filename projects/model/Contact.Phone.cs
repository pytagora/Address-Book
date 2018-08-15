using System;
using System.Collections;

namespace Model
{
    public partial class Contact
    {
        public class Phone
        {
            public string Number { get; set; }
            public Phone(string number)
            {
                Number = number;
            }
        }
    }
}