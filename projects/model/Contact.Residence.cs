using System;
using System.Collections;

namespace Model
{
    public partial class Contact
    {
        public class Residence
        {
            public string Address { get; set; }
            public Residence(string address)
            {
                Address = address;
            }
        }
    }
}