using System;

namespace Model
{
    public class PhoneNumber
    {
        private string _number;
        private string _type;

        public string Number
        {
            get => _number;
            set => _number = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }
    }
}