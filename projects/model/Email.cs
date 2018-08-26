using System;

namespace Model
{
    public class Email
    {
        private string _address = string.Empty;
        private string _type = string.Empty;
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
            set => _type = value;
        }
    }
}