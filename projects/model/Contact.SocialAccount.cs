using System;
using System.Collections;

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
        public class SocialAccounts : IEnumerable
        {
            private SocialAccount[] socialAccounts;
            public SocialAccounts(SocialAccount[] socialAccountArray)
            {
                int socialAccountArrayLength = socialAccountArray.Length;
                socialAccounts = new SocialAccount[socialAccountArrayLength];
                for (int i = 0; i < socialAccountArrayLength; ++i)
                {
                    socialAccounts[i] = socialAccountArray[i];
                }
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator) GetEnumerator();
            }
            public SocialAccountsEnum GetEnumerator()
            {
                return new SocialAccountsEnum(socialAccounts);
            }
        }
        public class SocialAccountsEnum : IEnumerator
        {
            public SocialAccount[] socialAccounts;
            int position = -1;
            public SocialAccountsEnum(SocialAccount[] list)
            {
                socialAccounts = list;
            }
            public bool MoveNext()
            {
                ++position;
                return (position < socialAccounts.Length);
            }
            public void Reset()
            {
                position = -1;
            }
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
            public SocialAccount Current
            {
                get
                {
                    try
                    {
                        return socialAccounts[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }
}