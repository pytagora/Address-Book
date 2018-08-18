using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using Model;

namespace Experiments
{
    class Experiment
    {
        static void Main()
        {
            List<Contact> contacts = new List<Contact>();
            Contact contact = new Contact
            {
                Id = 1,
                FirstName = "Valentino",
                LastName = "Skobljanec",
                Gender = "Male",
                //BirthDay = new DateTime(1992,9,7),
                BirthPlace = "Rijeka",
                Comment = "first user!"
            };
            Email mainEmail = new Email
            {
                Address = "vskobljanec@gmail.com",
                Type = "Home"
            };
            contact.AddEmail(mainEmail);
            Email schoolEmail = new Email
            {
                Address = "vskobljanec@uniri.hr",
                Type = "School"
            };
            contact.AddEmail(schoolEmail);
            contact.RemoveEmail(schoolEmail);
            Address addreess = new Address
            {
                AddressName = "Ilica",
                AddressNumber = 47,
                AddressCity = "Zagreb",
                AddressZip = 10000,
                AddressCountry = "Croatia"
            };
            contact.AddAddress(addreess);
            SocialAccount socialAccount = new SocialAccount
            {
                Id = "pytagora",
                SocialNetwork = "Github"
            };
            contact.AddSocialAccount(socialAccount);
            PhoneNumber phoneNumber = new PhoneNumber
            {
                Number = "1313164",
                Type = "Home"
            };
            contact.AddPhoneNumber(phoneNumber);
            var tmp = contact.GetEmails();
            foreach (var item in tmp)
            {
                Console.WriteLine("{0} - {1}", item.Address, item.Type);
            }
            contacts.Add(contact);
            Contact user = new Contact
            {
                FirstName = "Ivo",
                LastName = "Ivic",
                Gender = "Male",
            };
            contacts.Add(user);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            string jsonFile = @"..\\json.txt";
            using (StreamWriter streamWriter = new StreamWriter(jsonFile))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, contacts);
            }
            using (StreamReader r = new StreamReader(jsonFile))
            {
                string json = r.ReadToEnd();
                List<Contact> writeContacts = JsonConvert.DeserializeObject<List<Contact>>(json);
                foreach (var item in writeContacts)
                {
                    Console.WriteLine("{0} - {1} - {2}", item.FirstName, item.LastName, item.Gender);
                }
            }
        }
    }
}