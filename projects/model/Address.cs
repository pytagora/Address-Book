using System;

namespace Model
{
    public class Addreess
    {
        private string _addressName = "";
        private int _addressNumber;
        private string _addressCity = "";
        private int _addressZip;
        private string _addressCountry = "";
        public string AddressStreet()
        {
            if (_addressName != "" && _addressNumber != 0)
            {
                return _addressName + _addressNumber;
            }
            else
            {
                return "";
            }
        }
        public string FullAddress()
        {
            if (_addressCity != "" && _addressNumber != 0 && _addressCountry != "")
            {
                string result = _addressName + " " + AddressNumber + " " + _addressZip + " " + _addressCity + ", " + _addressCountry;
                return result;
            }
            else
            {
                return "Not Defined!";
            }
        }
        public string AddressName
        {
            get => _addressName;
            set
            {
                if (value.Length > 4 && value.Length < 35 && value.IsNormalized())
                {
                    _addressName = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public int AddressNumber
        {
            get => _addressNumber;
            set
            {
                if (value > 0 && value < 20000)
                {
                    _addressNumber = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public string AddressCity
        {
            get => _addressCity;
            set
            {
                if (value.Length > 1 && value.Length < 35 && value.IsNormalized())
                {
                    _addressCity = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public int AddressZip
        {
            get => _addressZip;
            set
            {
                if (value > 0 && value < 20000)
                {
                    _addressZip = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public string AddressCountry
        {
            get => _addressCountry;
            set
            {
                if (value.Length > 1 && value.Length < 35 && value.IsNormalized())
                {
                    _addressCountry = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
    }
}