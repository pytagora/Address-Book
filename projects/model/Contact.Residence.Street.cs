using System;

namespace Model
{
    public partial class Contact
    {
        public partial class Residence
        {
            private string streetName = "";
            private int streetNumber = 0;
            public class Street
            {

            }
            public string StreetName
            {
                get
                {
                    return streetName;
                }
                set
                {
                    if (value.Length > 4 && value.Length < 35 && value.IsNormalized())
                    {
                        streetName = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
            public int StreetNumber
            {
                get
                {
                    return streetNumber;
                }
                set
                {
                    if (value > 0 && value < 20000)
                    {
                        streetNumber = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
        }
    }
}