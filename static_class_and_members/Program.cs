using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("AA", "aa", "IT");
            Calisan calisan2 = new Calisan("BB", "bb", "IT");
            Calisan calisan3 = new Calisan("CC", "cc", "IT");

            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
            Console.WriteLine("Toplama işleminin sonucu: {0}", Islemler.sum(100, 200));
            Console.WriteLine("Çıkarma işleminin sonucu: {0}", Islemler.subtraction(200, 100));
        }

        class Calisan
        {
            private static int calisanSayisi; //field

            public static int CalisanSayisi { get => calisanSayisi; } //property

            private string Isim;
            private string Soyisim;
            private string Departman;

            static Calisan()
            {
                calisanSayisi = 0;
            }
            public Calisan(string isim, string soyisim, string departman) //constructor
            {
                this.Isim = isim;
                this.Soyisim = soyisim;
                this.Departman = departman;
                calisanSayisi++;
            }
        }

        static class Islemler
        {
            public static long sum(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }
            public static long subtraction(int sayi1, int sayi2)
            {
                return sayi1 - sayi2;
            }
        }
    }
}