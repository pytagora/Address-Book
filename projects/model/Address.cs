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
            set => _street = value;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public int Zip
        {
            get => _zip;
            set => _zip = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }
    }
}