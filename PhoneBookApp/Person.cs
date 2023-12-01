using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiUygulaması
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"İsim: {FirstName}, Soyisim: {LastName}, Telefon Numarası: {PhoneNumber}";
        }
    }
}

