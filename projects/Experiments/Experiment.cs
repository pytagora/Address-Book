using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using Model;
using FluentValidation;
using FluentValidation.Results;

namespace Experiments
{
    class Experiment
    {
        static void ValidationResults(ValidationResult results)
        {
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }
        }
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
            ContactValidator contactValidator = new ContactValidator();
            ValidationResult results = contactValidator.Validate(contact);
            ValidationResults(results);

            Email mainEmail = new Email
            {
                Address = "vskobljanec@gmail.com",
                Type = "Home"
            };
            EmailValidator emailValidator = new EmailValidator();
            results = emailValidator.Validate(mainEmail);
            ValidationResults(results);
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
                Street = "Ilica",
                Number = 47,
                City = "Zagreb",
                Zip = 10000,
                Country = "Croatia"
            };
            AddressValidator addressValidator = new AddressValidator();
            results = addressValidator.Validate(addreess);
            ValidationResults(results);
            contact.AddAddress(addreess);

            SocialAccount socialAccount = new SocialAccount
            {
                Id = "pytagora",
                SocialNetwork = "Github"
            };
            SocialAccountValidator socialAccountValidator = new SocialAccountValidator();
            results = socialAccountValidator.Validate(socialAccount);
            ValidationResults(results);
            contact.AddSocialAccount(socialAccount);

            PhoneNumber phoneNumber = new PhoneNumber
            {
                Number = "1313164",
                Type = "Home"
            };
            PhoneNumberValidator phoneNumberValidator = new PhoneNumberValidator();
            results = phoneNumberValidator.Validate(phoneNumber);
            ValidationResults(results);
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