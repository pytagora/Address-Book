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
            set
            {
                if (value.Length < 20 && value.Length > 4 && value.IsNormalized())
                {
                    _id = value;
                }
                else
                    throw new InvalidOperationException();
            }
        }
        public string SocialNetwork
        {
            get => _socialNetwork;
            set
            {
                if (value.Length < 20 && value.Length > 4 && value.IsNormalized())
                {
                    _socialNetwork = value;
                }
                else
                    throw new InvalidOperationException();
            }
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