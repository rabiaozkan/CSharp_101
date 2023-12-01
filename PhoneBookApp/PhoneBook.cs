using System;
using System.Collections.Generic;
using System.Text;

public class PhoneBook
{
    private List<Person> _contacts = new List<Person>();

    public void AddContact(Person person)
    {
        _contacts.Add(person);
    }

    public void DeleteContact(string nameOrSurname)
    {
        var contact = _contacts.FirstOrDefault(c => c.FirstName == nameOrSurname || c.LastName == nameOrSurname);
        if (contact != null)
        {
            _contacts.Remove(contact);
            Console.WriteLine($"{contact.FirstName} {contact.LastName} başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
        }
    }

    public void UpdateContact(string nameOrSurname, Person updatedContact)
    {
        var contact = _contacts.FirstOrDefault(c => c.FirstName == nameOrSurname || c.LastName == nameOrSurname);
        if (contact != null)
        {
            _contacts.Remove(contact);
            _contacts.Add(updatedContact);
            Console.WriteLine("Kişi güncellendi.");
        }
        else
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
        }
    }

    public void ListContacts()
    {
        foreach (var contact in _contacts)
        {
            Console.WriteLine(contact);
        }
    }

    public void SearchContact(string searchTerm)
    {
        var results = _contacts.Where(c => c.FirstName.Contains(searchTerm) || c.LastName.Contains(searchTerm) || c.PhoneNumber.Contains(searchTerm));
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}
