using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web;
using Newtonsoft.Json.Converters;
using System.IO;
using Model;

namespace Experiments
{
    class Experiment
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            Contact contact = new Contact
            {
                FirstName = "Valentino",
                LastName = "Skobljanec",
                Gender = "Male",
                BirthPlace = "Rijeka",
            };
            Email MainEmail = new Email();
            MainEmail.Address = "vskobljanec@gmail.com";
            MainEmail.Type = "Home";
            contact.AddEmail(MainEmail);
            Email SchoolEmail = new Email();
            SchoolEmail.Address = "vskobljanec@uniri.hr";
            SchoolEmail.Type = "School";
            contact.AddEmail(SchoolEmail);
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
