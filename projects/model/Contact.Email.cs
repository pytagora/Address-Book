﻿using System;
using System.Collections;

namespace Model
{
    public partial class Contact
    {
        public class Email
        {
            public string Address { get; set; }
            public Email(string address)
            {
                Address = address;
            }
        }
        public class Emails : IEnumerable
        {
            private Email[] emails;
            public Emails(Email[] emailArray)
            {
                int emailArrayLength = emailArray.Length;
                emails = new Email[emailArrayLength];
                for (int i = 0; i < emailArrayLength; ++i)
                {
                    emails[i] = emailArray[i];
                }
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator) GetEnumerator();
            }
            public EmailsEnum GetEnumerator()
            {
                return new EmailsEnum(emails);
            }
        }
        public class EmailsEnum : IEnumerator
        {
            public Email[] emails;
            int position = -1;
            public EmailsEnum(Email[] list)
            {
                emails = list;
            }
            public bool MoveNext()
            {
                ++position;
                return (position < emails.Length);
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
            public Email Current
            {
                get
                {
                    try
                    {
                        return emails[position];
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