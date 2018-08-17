using System;
using System.Text.RegularExpressions;

namespace Model
{
    public class Phone
    {
        public string phoneNumber;
        private string _type;
        public string Number
        {
            get => phoneNumber;
            set
            {
                if (Regex.IsMatch(value, @"^d+$"))
                {
                    phoneNumber = value;
                }
                else
                    throw new InvalidOperationException();
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