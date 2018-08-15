using System;
using System.Collections;

namespace Model
{
    public partial class Contact
    {
        public class Email
        {
            private string address = "";
            private string type = "";
            public Email()
            {

            }
            public string Address
            {
                get
                {
                    return address;
                }
                set
                {
                    if (IsValidEmail(value))
                    {
                        address = value;
                    }
                    else
                        throw new InvalidOperationException;
                }
            }
            public bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return true;
                }
                catch
                {
                    return false;
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