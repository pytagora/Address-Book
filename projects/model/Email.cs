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
                _address = value;
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