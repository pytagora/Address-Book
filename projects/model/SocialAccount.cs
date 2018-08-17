using System;

namespace Model
{
    public class SocialAccount
    {
        private string id;
        private string socialNetwork;
        private string hyperlink = "";
        public SocialAccount()
        {

        }
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value.Length < 20 && value.Length > 4 && value.IsNormalized())
                {
                    id = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public string SocialNetwork
        {
            get
            {
                return socialNetwork;
            }
            set
            {
                if (value.Length < 20 && value.Length > 4 && value.IsNormalized())
                {
                    socialNetwork = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public string Hyperlink
        {
            get
            {
                return hyperlink;
            }
            set
            {
                if (id != "" && socialNetwork != "")
                {
                    hyperlink = "https://www." + socialNetwork + ".com/" + id;
                }
            }
        }
    }
}