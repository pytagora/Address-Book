namespace Model
{
    public partial class Contact
    {
        public class Address
        {
            public string address { get; set; }
            public Address(string name)
            {
                address = name;
            }
        }
    }
}