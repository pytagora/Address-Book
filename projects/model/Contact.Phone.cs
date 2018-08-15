using System;
using System.Text.RegularExpressions;

namespace Model
{
    public partial class Contact
    {
        public class Phone
        {
            public string number;
            private string type;
            public Phone()
            {

            }
            public string Number
            {
                get
                {
                    return number;
                }
                set
                {
                    if (Regex.IsMatch(value, @"^d+$"))
                    {
                        number = value;
                    }
                    else
                        throw new InvalidOperationException;
                }
            }
            public string Type
            {
                get
                {
                    return type;
                }
                set
                {
                    if (value.Length > 1 && value.Length < 20 && value.IsNormalized())
                    {
                        type = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
        }
    }
}