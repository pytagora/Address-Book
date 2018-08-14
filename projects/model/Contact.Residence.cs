using System;
using System.Collections;

namespace Model
{
    public partial class Contact
    {
        public class Residence
        {
            public string Address { get; set; }
            public Residence(string address)
            {
                Address = address;
            }
        }
        public class Residences : IEnumerable
        {
            private Residence[] residences;
            public Residences(Residence[] residenceArray)
            {
                int residenceArrayLength = residenceArray.Length;
                residences = new Residence[residenceArrayLength];
                for (int i = 0; i < residenceArrayLength; ++i)
                {
                    residences[i] = residenceArray[i];
                }
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator) GetEnumerator();
            }
            public ResidencesEnum GetEnumerator()
            {
                return new ResidencesEnum(residences);
            }
        }
        public class ResidencesEnum : IEnumerator
        {
            public Residence[] residences;
            int position = -1;
            public ResidencesEnum(Residence[] list)
            {
                residences = list;
            }
            public bool MoveNext()
            {
                ++position;
                return (position < residences.Length);
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
            public Residence Current
            {
                get
                {
                    try
                    {
                        return residences[position];
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