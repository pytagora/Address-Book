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