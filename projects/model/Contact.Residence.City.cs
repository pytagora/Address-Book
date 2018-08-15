using System;

namespace Model
{
    public partial class Contact
    {
        public partial class Residence
        {
            private string cityName = "";
            private int cityZIP = 0;
            private string cityCountry = "";
            public class City
            {

            }
            public string CityName
            {
                get
                {
                    return cityName;
                }
                set
                {
                    if (value.Length > 1 && value.Length < 35 && value.IsNormalized())
                    {
                        cityName= value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
            public int CityZIP
            {
                get
                {
                    return cityZIP;
                }
                set
                {
                    if (value > 0 && value < 20000)
                    {
                        cityZIP = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
            public string CityCountry
            {
                get
                {
                    return cityCountry;
                }
                set
                {
                    if (value.Length > 1 && value.Length < 35 && value.IsNormalized())
                    {
                        cityCountry = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
        }
    }
}