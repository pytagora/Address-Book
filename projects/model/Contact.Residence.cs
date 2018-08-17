using System;
using System.Collections;

namespace Model
{
    public partial class Contact
    {
        public class Addreess
        {
            private string addressName = "";
            private int addressNumber = 0;
            private string addressCity = "";
            private int addressZIP = 0;
            private string addressCountry = "";
            public Addreess()
            {
                
            }
            public string AddressStreet()
            {
                if (addressName != "" && addressNumber != 0)
                {
                    return addressName + addressNumber;
                }
                else
                {
                    return "";
                }
            }
            public string ResidenceCity()
            {
                if (addressCity != "" && addressNumber != 0 && addressCountry != "")
                {
                    string result = addressZIP + " " + addressCity + ", " + addressCountry;
                    return result;
                }
                else
                {
                    return "Not Defined!";
                }
            }
            public string StreetName
            {
                get
                {
                    return addressName;
                }
                set
                {
                    if (value.Length > 4 && value.Length < 35 && value.IsNormalized())
                    {
                        addressName = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
            public int StreetNumber
            {
                get
                {
                    return addressNumber;
                }
                set
                {
                    if (value > 0 && value < 20000)
                    {
                        addressNumber = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
            public string CityName
            {
                get
                {
                    return addressCity;
                }
                set
                {
                    if (value.Length > 1 && value.Length < 35 && value.IsNormalized())
                    {
                        addressCity = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
            public int CityZIP
            {
                get
                {
                    return addressZIP;
                }
                set
                {
                    if (value > 0 && value < 20000)
                    {
                        addressZIP = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
            public string CityCountry
            {
                get
                {
                    return addressCountry;
                }
                set
                {
                    if (value.Length > 1 && value.Length < 35 && value.IsNormalized())
                    {
                        addressCountry = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
        }
    }
}