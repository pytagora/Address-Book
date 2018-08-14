namespace Model
{
    public partial class Contact
    {
        public class Number
        {
            public string Id { get; set; }
            public Number(string number)
            {
                Id = number;
            }
        }
    }
}