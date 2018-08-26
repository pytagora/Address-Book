using System;

namespace Model
{
    public class Address
    {
        private string _street = string.Empty;
        private int _number;
        private string _city = string.Empty;
        private int _zip;
        private string _country = string.Empty;

        public string FullAddress
        {
            get { return $"{_street} {_number} {_zip} {_city} {_country}"; }
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