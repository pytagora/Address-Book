using System;

namespace Model
{
    public class SocialAccount
    {
        private string _id;
        private string _socialNetwork;
        private string _hyperlink = "";

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public string SocialNetwork
        {
            get => _socialNetwork;
            set => _socialNetwork = value;
        }

        public string Hyperlink
        {
            get => _hyperlink;
            set
            {
                if (_id != "" && _socialNetwork != "")
                {
                    _hyperlink = "https://www." + _socialNetwork + ".com/" + _id;
                }
            }
        }
    }
}