using System;

namespace Model
{
    public class Email
    {
        private string _address = "";
        private string _type = "";
        public string Address
        {
            get => _address;
            set
            {
                if (IsValidEmail(value))
                {
                    _address = value;
                }
                else
                    throw new InvalidOperationException();
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
            get => _type;
            set
            {
                if (value.Length > 1 && value.Length < 20 && value.IsNormalized())
                {
                    _type = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
    }
}