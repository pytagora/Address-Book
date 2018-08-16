﻿using System;
using static Model.Contact;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Collections.Generic;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Contact contact = new Contact();
            Console.WriteLine("\t***Welcome to my console application!!!***");
            Console.WriteLine("\n\n\t\tADDRESS BOOK");
            Console.WriteLine("\n\nCONTACT FORM: ");
            Console.Write("\nEnter contact's first name: ");
            contact.FirstName = Console.ReadLine(); 
            Console.WriteLine("Enter contact's last name: ");
            contact.LastName = Console.ReadLine();
            Console.Write("To add contact's birthplace press key 'A': ");
            char key = Console.ReadKey().KeyChar;
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter contact's birthplace: ");
                contact.BirthPlace = Console.ReadLine();
            }
            Console.WriteLine("\nTo add contact's birthday press key 'A': ");
            key = Console.ReadKey().KeyChar;
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter contact's birthday in the format MM/dd/yyyy: ");
                string birthday = Console.ReadLine();
                DateTime dateTime = Convert.ToDateTime(birthday);
                contact.BirthDay = dateTime;
            }
            Console.WriteLine("To add contact's gender press key 'A': ");
            key = Console.ReadKey().KeyChar;
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter contact's gender: ");
                contact.Gender = Console.ReadLine();
            }
            Console.WriteLine("\nTo add contact's email press key 'A': ");
            key = Console.ReadKey().KeyChar;
            while(key == 'A' || key == 'a')
            {
                Email email = new Email();
                Console.WriteLine("\nEnter contact's new email: ");
                string tmpEmail = Console.ReadLine();
                //contact.AddEmail(email);
                Console.WriteLine("\nTo add another contact's email press 'A': ");
                key = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\nTo add contact's address press key 'A': ");
            key = Console.ReadKey().KeyChar;
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter contact's new address: ");
                string tmpAddress = Console.ReadLine();
                Residence address = new Residence();
                //contact.AddAddress(address);
                Console.WriteLine("\nTo add another contact's address press key 'A': ");
                key = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\nTo add contact's number press key 'A': ");
            key = Console.ReadKey().KeyChar;
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter contact's new number: ");
                string tmpNumber = Console.ReadLine();
                Phone phone = new Phone();
                //contact.AddNumber(phone);
                Console.WriteLine("\nTo add another contact's number press key 'A': ");
                key = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\nTo add contact's social account press key 'A': ");
            key = Console.ReadKey().KeyChar;
            SocialAccount socialAccount = new SocialAccount();
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter contact's new social account ID: ");
                socialAccount.ID = Console.ReadLine();
                Console.WriteLine("\nEnter contact's social network: ");
                socialAccount.SocialNetwork = Console.ReadLine();
                //contact.AddSocialAccount(socialAccount);
                Console.WriteLine("\nTo add another contact's social account press key 'A': ");
                key = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\nTo add comment for contact press key 'A': ");
            key = Console.ReadKey().KeyChar;
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter comment for the contact: ");
                contact.Comment = Console.ReadLine();
            }
            //Console.WriteLine("\nContact with a name '{0}' and email '{1}' birthplace '{2}' and birthday '{3}' gender '{4}' address '{5}' number '{6}' with social network id '{7}' and comment '{8}' created!\n", contact.FirstName + contact.LastName, contact.emails[0].ToString(), contact.BirthPlace, contact.BirthDay, contact.Gender, contact.addresses[0].Name, contact.numbers[0].Id, contact.socialAccounts[0].Name , contact.Comment);
            // var mejl = contact.emails[0].Address;
            // Console.WriteLine("mejl je '{0}'", mejl);
            socialAccount.Hyperlink = "";
            //string ime = "facebook";
            //string prezime = "pytagora";
            //var hyperlink = "https://www." + ime + ".com/" + prezime;
            Console.WriteLine("social account id is '{0}', social network is '{1}' and hyperlink is '{2}'", socialAccount.ID, socialAccount.SocialNetwork, socialAccount.Hyperlink);
            Console.WriteLine("\nProcess done. Press any key to exit.");*/
            List<Contact> contacts = new List<Contact>();
            //DateTime date = new DateTime(2017, 12, 1);
            Contact contact = new Contact
            {
                FirstName = "Valentino",
                LastName = "Skobljanec",
                Gender = "Male",
                BirthPlace = "Rijeka",
                // BirthDay = date
            };
            contacts.Add(contact);
            Contact user = new Contact
            {
                FirstName = "Ivo",
                LastName = "Ivic",
                Gender = "Male",
                //BirthDay = date
            };
            contacts.Add(user);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Valentino\Desktop\pytagora\Address-book\json.txt"))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, contacts);
            }
            string jsonFile = @"C:\Users\Valentino\Desktop\pytagora\Address-book\json.txt";
            using (StreamReader r = new StreamReader(jsonFile))
            {
                string json = r.ReadToEnd();
                List<Contact> writeContacts = JsonConvert.DeserializeObject<List<Contact>>(json);
                foreach (var item in writeContacts)
                {
                    Console.WriteLine("{0} - {1} - {2}",item.FirstName, item.LastName, item.Gender);
                }
            }
            //Console.WriteLine("First name is :" + jObject["FirstName"].ToString());*/
            Console.ReadKey();
            return;
        }
    }
}