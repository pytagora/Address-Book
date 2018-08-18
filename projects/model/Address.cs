using System;

namespace Model
{
    public class Address
    {
        private string _street = "";
        private int _number;
        private string _city = "";
        private int _zip;
        private string _country = "";
        public string FullAddress()
        {
            if (_city != "" && _number != 0 && _country != "")
            {
                string result = _street + " " + _number + " " + _zip + " " + _city + ", " + _country;
                return result;
            }
            else
            {
                return "Not Defined!";
            }
        }
        public string Street
        {
            get => _street;
            set
            {
                if (value.Length > 4 && value.Length < 35 && value.IsNormalized())
                {
                    _street = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public int Number
        {
            get => _number;
            set
            {
                if (value > 0 && value < 20000)
                {
                    _number = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public string City
        {
            get => _city;
            set
            {
                if (value.Length > 1 && value.Length < 35 && value.IsNormalized())
                {
                    _city = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public int Zip
        {
            get => _zip;
            set
            {
                if (value > 0 && value < 20000)
                {
                    _zip = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public string Country
        {
            get => _country;
            set
            {
                if (value.Length > 1 && value.Length < 35 && value.IsNormalized())
                {
                    _country = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
    }
}