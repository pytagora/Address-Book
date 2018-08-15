using System;
using System.Collections;

namespace Model
{
    public partial class Contact
    {
        public partial class Residence
        {
            public Residence()
            {
                
            }
            public string ResidenceStreet()
            {
                var streetName = StreetName;
                var streetNumber = StreetNumber;
                if (streetName != "" && streetNumber != 0)
                {
                    return streetName + streetNumber;
                }
                else
                {
                    return "";
                }
            }
            public string ResidenceCity()
            {
                string cityName = CityName;
                string cityZIP = CityZIP.ToString();
                string cityCountry = CityCountry;
                if (cityName != "" && streetNumber != 0 && cityCountry != "")
                {
                    string result = cityZIP + " " + cityName + ", " + cityCountry;
                    return result;
                }
                else
                {
                    return "Not Defined!";
                }
            }
        }
    }
}