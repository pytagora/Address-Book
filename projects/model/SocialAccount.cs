using System;

namespace Model
{
    public class SocialAccount
    {
        private string _id;
        private string _network = string.Empty;
        private string _hyperlink = string.Empty;

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public string Network
        {
            get => _network;
            set => _network = value;
        }

        public string Hyperlink
        {
            get => _hyperlink;
            set
            {
                if (_id != "" && _network != "")
                {
                    _hyperlink = "https://www." + _network + ".com/" + _id;
                }
            }
        }
    }
}