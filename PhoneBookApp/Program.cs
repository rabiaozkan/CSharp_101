using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static PhoneBook phoneBook = new PhoneBook();

    static void Main(string[] args)
    {
        // Varsayılan kişileri ekle
        LoadInitialContacts();

        bool exit = false;
        while (!exit)
        {
            ShowMenu();
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddNewContact();
                    break;
                case 2:
                    DeleteContact();
                    break;
                case 3:
                    UpdateContact();
                    break;
                case 4:
                    ListContacts();
                    break;
                case 5:
                    SearchContact();
                    break;
                default:
                    exit = true;
                    break;
            }
        }
    }

    static void LoadInitialContacts()
    {
        phoneBook.AddContact(new Person("Ahmet", "Yılmaz", "1234567890"));
        phoneBook.AddContact(new Person("Ayşe", "Kara", "2345678901"));
        phoneBook.AddContact(new Person("Mehmet", "Beyaz", "3456789012"));
        phoneBook.AddContact(new Person("Fatma", "Mavi", "4567890123"));
        phoneBook.AddContact(new Person("Ali", "Kırmızı", "5678901234"));
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)");
        Console.WriteLine("1) Yeni Numara Kaydetmek");
        Console.WriteLine("2) Varolan Numarayı Silmek");
        Console.WriteLine("3) Varolan Numarayı Güncelleme");
        Console.WriteLine("4) Rehberi Listelemek");
        Console.WriteLine("5) Rehberde Arama Yapmak");
        Console.WriteLine("Herhangi bir tuşa basarak çıkış yapabilirsiniz.\n");
    }

    static void AddNewContact()
    {
        Console.WriteLine("Lütfen isim giriniz:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Lütfen soyisim giriniz:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Lütfen telefon numarası giriniz:");
        string phoneNumber = Console.ReadLine();

        if (IsValidPhoneNumber(phoneNumber))
        {
            phoneBook.AddContact(new Person(firstName, lastName, phoneNumber));
            Console.WriteLine("Kişi rehbere eklendi.");
        }
        else
        {
            Console.WriteLine("Geçersiz telefon numarası. Lütfen tekrar deneyin.");
        }
    }

    static bool IsValidPhoneNumber(string number)
    {
        return number.All(char.IsDigit) && number.Length == 10;
    }


    static void DeleteContact()
    {
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        string nameOrSurname = Console.ReadLine();

        phoneBook.DeleteContact(nameOrSurname);
    }

    static void UpdateContact()
    {
        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        string nameOrSurname = Console.ReadLine();

        Console.WriteLine("Lütfen yeni isim giriniz:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Lütfen yeni soyisim giriniz:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Lütfen yeni telefon numarası giriniz:");
        string phoneNumber = Console.ReadLine();

        phoneBook.UpdateContact(nameOrSurname, new Person(firstName, lastName, phoneNumber));
    }

    static void ListContacts()
    {
        phoneBook.ListContacts();
    }

    static void SearchContact()
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: 1");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: 2");
        int searchType = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Arama terimini giriniz:");
        string searchTerm = Console.ReadLine();

        phoneBook.SearchContact(searchTerm);
    }


}
