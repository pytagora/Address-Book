using System;
using System.Collections;

namespace Model
{
    public partial class Contact
    {
        public class Phone
        {
            public string Number { get; set; }
            public Phone(string number)
            {
                Number = number;
            }
        }
        public class Phones : IEnumerable
        {
            private Phone[] phones;
            public Phones(Phone[] phoneArray)
            {
                int phoneArrayLength = phoneArray.Length;
                phones = new Phone[phoneArrayLength];
                for (int i = 0; i < phoneArrayLength; ++i)
                {
                    phones[i] = phoneArray[i];
                }
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator) GetEnumerator();
            }
            public PhonesEnum GetEnumerator()
            {
                return new PhonesEnum(phones);
            }
        }
        public class PhonesEnum : IEnumerator
        {
            public Phone[] phones;
            int position = -1;
            public PhonesEnum(Phone[] list)
            {
                phones = list;
            }
            public bool MoveNext()
            {
                ++position;
                return (position < phones.Length);
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
            public Phone Current
            {
                get
                {
                    try
                    {
                        return phones[position];
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