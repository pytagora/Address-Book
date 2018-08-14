namespace Model
{
    public partial class Contact
    {
        public class SocialAccount
        {
            public string Id { get; set; }
            public SocialAccount(string id)
            {
                Id = id;
            }
        }
    }
}