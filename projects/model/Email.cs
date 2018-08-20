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
            set => _type = value;
        }
    }
}